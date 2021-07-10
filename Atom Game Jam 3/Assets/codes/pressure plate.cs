using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    Animation door;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D doo)
    {
        if(doo.gameObject.tag==("mass"))
        {
            door.Play("open");

        }
    }

   
}
