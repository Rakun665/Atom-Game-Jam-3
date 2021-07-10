using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walldelet2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("y"))
        {
            Destroy(collision.gameObject);
        }
    }
}
