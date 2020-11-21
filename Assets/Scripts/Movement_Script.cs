using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour
{
    public Animator animator;
    public AnimatorControllerParameter animParam;
    public Transform crane;
    public Transform demPos;
    public Transform supPos;
    public float rotateYaw;
    public float dolly;
    public float hook;
    public bool demoMode = false;
    private Vector3 cranetoSupp;
    private Vector3 cranetoDem;
    float angle;
    float angle1;
    float pitchAngle;
    float yawSpeed;
    float pitchSpeed;
    float hookSpeed;
    float yDiff;
    float distCranetoSupp;
    float distCranetoDem;
    float pitchProj;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 cranetoSupp = supPos.position - crane.position;
        Vector3 cranetoDem = demPos.position - crane.position;
        angle = Vector3.Angle(cranetoSupp, cranetoDem);
        Debug.Log("Angle = " + angle);
        distCranetoSupp = Vector3.Distance(crane.position, supPos.position);
        Debug.Log("Crane to Supply = " + distCranetoSupp);
        distCranetoDem = Vector3.Distance(crane.position, demPos.position);
        Debug.Log("Crane to Demand = " + distCranetoDem);
        pitchProj = distCranetoSupp - distCranetoDem;
        Debug.Log("Dolly dist Travel " + pitchProj);
        yawSpeed = 1.0f;
        pitchSpeed = 0.01f;
        hookSpeed = 0.01f;
        yDiff = Mathf.Abs(supPos.position.y - demPos.position.y);
        angle1 = Mathf.Abs(angle / 3);
    }

    // Update is called once per frame
    void Update()
    {

        if (demoMode)
        {
            rotateYaw += Time.deltaTime * yawSpeed;
            dolly += Time.deltaTime * pitchSpeed;
            hook += Time.deltaTime * hookSpeed;
        }

        animator.SetFloat("Param_crane", Mathf.Abs(rotateYaw * angle1) % 360);
        animator.SetFloat("Param_telpher", dolly * pitchProj);
        animator.SetFloat("Param_hook", hook * yDiff);
    }
}
