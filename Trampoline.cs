using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int Jump928 = 10;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение силы прыжка
        other.GetComponent<Jump>().jumpStrength = Jump928;

    }

    void OnTriggerExit(Collider other)
    {
        //Уменьшение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 2;
    }

}
