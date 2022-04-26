using UnityEngine;
using System.Collections;
 
public class CloseApp : MonoBehaviour {
 
    void Awake() {
        Input.backButtonLeavesApp = true;
    }
   
    void Update () {

        // close app on X
        if (Input.GetKeyUp(KeyCode.Escape)) {
            Debug.Log("Goodbye cruel world!");
            Application.Quit();
        }
    }
}