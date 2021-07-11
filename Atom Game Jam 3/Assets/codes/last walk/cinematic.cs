using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinematic : MonoBehaviour
{
    Animator fin;
     void Start()
    {
        fin = GetComponent<Animator>();  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag==("f"))
        {
            fin.SetBool("finn", true);
        }
    }
}
