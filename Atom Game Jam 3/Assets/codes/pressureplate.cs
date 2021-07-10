using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    
    Animator door;

    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 void OnTriggerEnter2D(Collider2D doo)
    {
        if(doo.gameObject.tag==("mass"))
        {
            print("x");
           door.SetBool("openn", true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == ("mass"))
        {
            print("y");
            door.SetBool("openn", false);
        }
    }


}
