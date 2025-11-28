using UnityEngine;

public class HeadCollisionFade : MonoBehaviour
{
    public Color fadeColor = Color.black;
    public float fadeDuration = 0.5f;
    public LayerMask collisionLayer; // Set this to "Default" or "Walls"

    private Material cameraFadeMat;
    private bool isFading = false;

    void Start()
    {
        // Create a temporary material for fading
        cameraFadeMat = new Material(Shader.Find("Universal Render Pipeline/Unlit"));
        cameraFadeMat.color = new Color(0, 0, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if we hit a wall
        if (((1 << collision.gameObject.layer) & collisionLayer) != 0)
        {
            isFading = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (((1 << collision.gameObject.layer) & collisionLayer) != 0)
        {
            isFading = false;
        }
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (isFading)
        {
            // Simple fade logic (you might need a UI canvas approach for URP)
            // For URP, it's better to enable a black UI Canvas in front of the camera
        }
    }
}