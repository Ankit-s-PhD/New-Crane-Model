using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private GameObject _player;
    private bool _collidewithbuilding;
    private bool _collidewithwalkway;
    private bool _collidewithvehicle;
    private bool _collidewithsitestr;
    private bool _collidewithriggers;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Building"))
        {
            _collidewithbuilding = true;
        }

        if (other.CompareTag("Walkway"))
        {
            _collidewithwalkway = true;
        }

        if (other.CompareTag("Vehicle"))
        {
            _collidewithvehicle = true;
        }

        if (other.CompareTag("Site_Structure"))
        {
            _collidewithsitestr = true;
        }

        if (other.CompareTag("Riggers"))
        {
            _collidewithriggers = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Building"))
        {
            _collidewithbuilding = false;
        }

        if (other.CompareTag("Walkway"))
        {
            _collidewithwalkway = false;
        }

        if (other.CompareTag("Vehicle"))
        {
            _collidewithvehicle = false;
        }

        if (other.CompareTag("Site_Structure"))
        {
            _collidewithsitestr = false;
        }

        if (other.CompareTag("Riggers"))
        {
            _collidewithriggers = false;
        }
    }
    
    private void Penalty()
    {
        if (_collidewithbuilding)
        {
            _player.GetComponent<Player>().TakeDamage(0.9f);
        }

        if (_collidewithwalkway)
        {
            _player.GetComponent<Player>().TakeDamage(0.3f);
        }

        if (_collidewithvehicle)
        {
            _player.GetComponent<Player>().TakeDamage(0.7f);
        }

        if (_collidewithsitestr)
        {
            _player.GetComponent<Player>().TakeDamage(0.5f);
        }

        if (_collidewithriggers)
        {
            _player.GetComponent<Player>().TakeDamage(0.5f);
        }
    }
}
