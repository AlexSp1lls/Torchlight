using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class PlatformScript : MonoBehaviour
{
   
    public Rigidbody2D rb;
 
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Fire")
       {
           Destroy(gameObject);
           
       }
   }

  
}
