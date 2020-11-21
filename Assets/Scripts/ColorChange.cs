using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color yellowcolor;
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Load"))
        {
            Debug.Log("Collision Detected");
            transform.GetComponent<Renderer>().material.color = yellowcolor;
        }
    }
}
