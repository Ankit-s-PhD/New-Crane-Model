using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenalyPoints : MonoBehaviour
{
    public Slider slider;

    public void SetMaxPenalty(int penalty)
    {
        slider.maxValue = penalty;
        slider.value = penalty;
    }

    public void SetPenalty(int penalty)
    {
        slider.value = penalty;
    }
}
