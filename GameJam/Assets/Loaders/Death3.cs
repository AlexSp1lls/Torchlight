using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.EventSystems;
using UnityEditor.UIElements;
using UnityEditor.SceneManagement;

public class Death3 : MonoBehaviour
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
            SceneManager.LoadScene(7);
            Cursor.visible = true;
       }
   }
}
