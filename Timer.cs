using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class Timer : MonoBehaviour
{

    public float seconds = 59f;
    //public float minutes = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > 0)
        {
            seconds -= Time.deltaTime;
        }
        /*else if (minutes > 0)
        {
            minutes -= 1;
            seconds = 59f;
        }*/
        else
        {
            EditorSceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        print(seconds);
    }
}
