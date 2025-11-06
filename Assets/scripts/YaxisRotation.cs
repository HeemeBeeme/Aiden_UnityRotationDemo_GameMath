using UnityEngine;

public class YaxisRotation : MonoBehaviour
{

    public float Amplitude = 90f;
    public float Frequency = 0.5f;
    public float TimeElapsed = 0.0f;

    public int Speed = 5;

    void Update()
    {
        transform.eulerAngles = new Vector3(0, (Amplitude * Mathf.Sin(Frequency * TimeElapsed) + 2), 0);

        TimeElapsed += Time.deltaTime * Speed;
    }
}