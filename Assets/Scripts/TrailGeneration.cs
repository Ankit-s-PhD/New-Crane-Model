using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailGeneration : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider leftSide1;
    public Collider rightSide1;
    public Material rightSideMaterial;
    public Material leftSideMaterial;
    public Material trailMaterial;
   
    private Rigidbody rb;
    private Collider facade;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        facade = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        Vector3 closestToFacade = facade.ClosestPoint(transform.position);
        LeaveTrail(closestToFacade, .1f, trailMaterial);
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 closestToLeftSide = other.ClosestPoint(leftSide1.transform.position);
        if (Vector3.Distance(closestToLeftSide, leftSide1.transform.position) < 0.03f)
        { LeaveTrail(closestToLeftSide, 0.1f, leftSideMaterial); }

        Vector3 closestToRightSide = other.ClosestPoint(rightSide1.transform.position);
        if (Vector3.Distance(closestToRightSide, rightSide1.transform.position) < 0.03f)
        { LeaveTrail(closestToRightSide, 0.1f, rightSideMaterial); }
    }

        private void LeaveTrail(Vector3 point, float scale, Material material)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.localScale = Vector3.one * scale;
            sphere.transform.position = point;
            sphere.transform.parent = transform.parent;
            sphere.GetComponent<Collider>().enabled = false;
            sphere.GetComponent<Renderer>().material = material;
            Destroy(sphere, 10f);
        }
}