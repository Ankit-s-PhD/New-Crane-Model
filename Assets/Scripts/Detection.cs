using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public GameObject sphereGen;
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Envelope"))
            {
            Debug.Log("Check");
               GameObject obj = GameObject.Instantiate(sphereGen) as GameObject;
            Vector3 pos = transform.position;
            obj.transform.position = pos;
            }
        }
}