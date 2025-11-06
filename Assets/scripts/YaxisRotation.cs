using UnityEngine;

public class YaxisRotation : MonoBehaviour
{

    public float Amplitude = 1.0f;
    public float Frequency = 1.0f;
    public float TimeElapsed = 0.0f;

    public int Speed = 1;

    void Update()
    {
        transform.eulerAngles = new Vector3(0, (Amplitude * Mathf.Sin(Frequency * TimeElapsed) + 2), 0);

        TimeElapsed += Time.deltaTime * Speed;
    }
}