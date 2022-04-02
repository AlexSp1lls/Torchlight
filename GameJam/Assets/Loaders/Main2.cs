using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.EventSystems;
using UnityEditor.UIElements;
using UnityEditor.SceneManagement;

public class Main2 : MonoBehaviour
{
  public void LoadSceneSelect()
     {
         SceneManager.LoadScene(2);
     }

 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
}
