using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider2D other)
    {    
            GetComponent(other.gameObject.tag);
        if (other.tag == "Player")
        {   
             Destroy(other.gameObject);
           
        }
       
    }
   


}
