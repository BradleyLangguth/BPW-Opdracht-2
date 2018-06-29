using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    


 public void ChangeScene(string scenename)
 {
  Application.LoadLevel(scenename);
 }
    
 public void Exit()
 {
  Application.Quit();
 }

}
