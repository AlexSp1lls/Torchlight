using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {


  public void LoadSceneSelect()
     {
         SceneManager.LoadScene(1);
         Cursor.visible = false;
     }

 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
  
}