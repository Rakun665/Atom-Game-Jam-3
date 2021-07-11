using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lastscene1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
            if (collision.gameObject.tag == ("U"))
            {
            SceneManager.LoadScene("Last");
            }
        
    }
}
