using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walldelet : MonoBehaviour
{
    [SerializeField] GameObject wall1;
   

        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== ("x"))
        {
            Destroy(collision.gameObject);
        }
    }
}
