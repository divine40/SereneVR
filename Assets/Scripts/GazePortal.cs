using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GazePortal : MonoBehaviour
{
    [Header("Settings")]
    public string sceneToLoad;      // Name of the scene to load (e.g., "Forest")
    public float gazeTime = 3.0f;   // How long to stare

    [Header("Visuals")]
    public Image loaderImage;       // Drag your "Loader" UI Image here
    public Transform playerCamera;  // Drag your Main Camera here

    private float timer = 0.0f;

    void Update()
    {
        // 1. Shoot a Ray from the Camera
        Ray ray = new Ray(playerCamera.position, playerCamera.forward);
        RaycastHit hit;

        // 2. Check if we hit THIS object (the sphere)
        if (Physics.Raycast(ray, out hit) && hit.transform == this.transform)
        {
            // We are looking at it! Count up.
            timer += Time.deltaTime;

            // Animate the Ring: Divide current time by total time (e.g., 1.5 / 3.0 = 0.5 fill)
            if (loaderImage != null)
            {
                loaderImage.fillAmount = timer / gazeTime;
            }

            // Check if done
            if (timer >= gazeTime)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
        else
        {
            // We looked away! Reset everything.
            timer = 0.0f;
            if (loaderImage != null)
            {
                loaderImage.fillAmount = 0.0f;
            }
        }
    }
}