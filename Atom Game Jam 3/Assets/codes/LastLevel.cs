using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag==("mass"))
            {

        }
        SceneManager.LoadScene("Walk");
    }
}
