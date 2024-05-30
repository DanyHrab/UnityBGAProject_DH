using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        sceneName  = SceneManager.GetActiveScene().name;
        EditorSceneManager.LoadScene(sceneName);
    }
}
