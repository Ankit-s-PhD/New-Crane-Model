using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider Collision_penalty;
    public float maxPenalty = 1.0f;

    private float _currenthealth;

    private void Start()
    {
        _currenthealth = maxPenalty;
    }

    public void TakeDamage(float damage)
    {
        _currenthealth -= damage;
        Collision_penalty.value = _currenthealth;

    }
}
