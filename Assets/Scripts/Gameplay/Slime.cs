using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slime : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
    {
    Scene currentScene = SceneManager.GetActiveScene();
    string sceneName = currentScene.name;
    if(other.CompareTag("Hero"))
    {
        if(sceneName == "rpgScene")
        {
            SceneManager.LoadScene(1);
        }

    }

    }
}
