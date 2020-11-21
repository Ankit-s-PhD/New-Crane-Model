 
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target;
    public Transform cabin;
    public float smoothSpeed = 0.125f;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = cabin.position;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
        transform.LookAt(target);
    }
}
