using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class LevelExit1 : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Exit")
       {
           Destroy(gameObject);
           
            SceneManager.LoadScene(2);
            
       }
   }
}
