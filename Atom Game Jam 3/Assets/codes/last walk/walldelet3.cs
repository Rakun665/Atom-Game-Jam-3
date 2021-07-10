using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walldelet3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("z"))
        {
            Destroy(collision.gameObject);
        }
    }
}
