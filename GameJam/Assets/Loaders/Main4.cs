using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.EventSystems;
using UnityEditor.UIElements;
using UnityEditor.SceneManagement;
public class Main4 : MonoBehaviour
{
     public void LoadSceneSelect()
     {
         SceneManager.LoadScene(4);
     }

 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
}
