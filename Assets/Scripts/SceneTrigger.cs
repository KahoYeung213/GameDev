using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");

            // Loads ship scene
            SceneManager.LoadScene("Ship Scene");
            Debug.Log("triggered");
        }
    }
}