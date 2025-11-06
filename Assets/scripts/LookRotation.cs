using UnityEngine;

public class LookRotation : MonoBehaviour
{

    public GameObject Target;
    public GameObject UpTargetObj;

    public float Speed = 0.5f;

    void Update()
    {
        Vector3 Direction = Target.transform.position - transform.position;
        Vector3 UpTarget = UpTargetObj.transform.position - transform.position;

        Quaternion DirectionQuat = Quaternion.LookRotation(Direction, UpTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, DirectionQuat, Time.deltaTime * Speed);
    }
}
