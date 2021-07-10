using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D doo)
    {
        if (doo.gameObject.tag == ("mass"))
        {
            print("x");
           
        }
    }

}
