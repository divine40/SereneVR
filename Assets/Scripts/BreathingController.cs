using UnityEngine;
using System.Collections;

public class BreathingController : MonoBehaviour
{
    [Header("Breathing Rhythm (Seconds)")]
    public float inhaleTime = 4.0f;
    public float holdTime = 7.0f;
    public float exhaleTime = 8.0f;

    [Header("Size Settings")]
    public Vector3 minSize = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 maxSize = new Vector3(1.5f, 1.5f, 1.5f);

    void Start()
    {
        StartCoroutine(BreathingLoop());
    }

    IEnumerator BreathingLoop()
    {
        while (true)
        {
            // Inhale (Expand)
            yield return Resize(minSize, maxSize, inhaleTime);

            // Hold (Stay Big)
            yield return new WaitForSeconds(holdTime);

            // Exhale (Shrink)
            yield return Resize(maxSize, minSize, exhaleTime);

            // Small Pause
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator Resize(Vector3 start, Vector3 end, float time)
    {
        float elapsed = 0;
        while (elapsed < time)
        {
            transform.localScale = Vector3.Lerp(start, end, elapsed / time);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localScale = end;
    }
}