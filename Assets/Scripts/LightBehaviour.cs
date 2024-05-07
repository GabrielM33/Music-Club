using System.Collections;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(LightBlink());
    }
    
    private IEnumerator LightBlink()
    {
        Light light = GetComponent<Light>();
        float duration = 2.0f; // duration of the effect
        float maxIntensity = 100.0f; // maximum intensity

        // Gradually increase the intensity from 0 to maxIntensity
        for (float t = 0; t < duration / 2; t += Time.deltaTime)
        {
            light.intensity = Mathf.Lerp(0, maxIntensity, t / (duration / 2));
            yield return null;
        }

        // Gradually decrease the intensity from maxIntensity to 0
        for (float t = 0; t < duration / 2; t += Time.deltaTime)
        {
            light.intensity = Mathf.Lerp(maxIntensity, 0, t / (duration / 2));
            yield return null;
        }
    }

}