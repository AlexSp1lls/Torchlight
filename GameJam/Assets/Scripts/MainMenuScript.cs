using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.EventSystems;
using UnityEditor.UIElements;
using UnityEditor.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

  public void LoadSceneSelect()
     {
         SceneManager.LoadScene(1);
     }

 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
  
}
