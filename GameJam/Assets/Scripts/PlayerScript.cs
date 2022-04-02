using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] bool isPlayerDead = false;
    public Rigidbody2D rb;
    void Dead()
   {
      
   }
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Fire")
       {
           Destroy(gameObject);
           isPlayerDead = true;
            SceneManager.LoadScene(6);
            Cursor.visible = true;
       }
   }

  
}
