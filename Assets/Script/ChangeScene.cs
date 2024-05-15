using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Set your scene name here
    //public string sceneName;

    public void ChangeScenesGo(string sceneChangeName)
    {
        // Change the scene
        SceneManager.LoadScene(sceneChangeName);
    }
}
