using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Variable to store the name of the scene to load
    public string SceneName;

    void Start ()
    {

    }
    // This method is called when the player collides with a Portal object
    void OnTriggerEnter()
    {
        // Load the specified scene
        SceneManager.LoadScene(SceneName);

    }
}




