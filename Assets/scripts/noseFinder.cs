using UnityEngine;

public class noseFinder : MonoBehaviour
{
    public GameObject Nose;
    void Start()
    {
        
    }

    void Update()
    {
        Nose.transform.position = transform.position + transform.forward;
    }
}
