using UnityEngine;

public class OrbitingScript : MonoBehaviour
{
    public GameObject Target;

    public float Speed = 0.5f;
    public float OrbitSpeed = 0.5f;

    void FixedUpdate()
    {
        Vector3 Direction = Target.transform.position - transform.position;
        Quaternion DirectionQuat = Quaternion.LookRotation(Direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, DirectionQuat, Time.deltaTime * Speed);

        transform.Translate(transform.forward * (OrbitSpeed), Space.World);
    }
}
