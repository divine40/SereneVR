using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required for UI events

public class ButtonSound : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    [Header("Audio Settings")]
    public AudioClip hoverSound;
    public AudioClip clickSound;

    [Range(0f, 1f)]
    public float volume = 0.5f;

    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component automatically if it's missing
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0; // 2D sound (plays in head)
    }

    // This runs when the VR Laser touches the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSound != null)
        {
            audioSource.PlayOneShot(hoverSound, volume);
        }
    }

    // This runs when the Trigger is pressed
    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound, volume);
        }
    }
}