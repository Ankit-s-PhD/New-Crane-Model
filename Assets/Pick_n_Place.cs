using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_n_Place : MonoBehaviour
{
    public Transform hook;
    bool text = false;
    string attachment = "Load attached to Hook";
    void OnTriggerEnter(Collider other)
    {
        text = true;
        Debug.Log("Load Attached");
        if (other.CompareTag("Player"))
        {
            this.transform.parent = hook.transform;
            this.transform.localPosition = new Vector3(0, 4.0f, 0);
            GetComponent<Rigidbody>().useGravity = false;
        }
       
    }
    
    
    void OnGUI()
    {
        if (text == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 200), attachment);
        }
        
    }

    void Update()
    {
         if (Input.GetKey(KeyCode.Space))
         {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
  
}
