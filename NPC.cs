using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int level = 1;
    public int health = 5;
    float speed = 1.2f;
    Vector3 newPosition; 
    
    // Start is called before the first frame update
    void Start()
    {
        // Adds the level to the health at the start of the level
        health += level;

        // Prints health
        print(health);

        newPosition.x = -17;
        newPosition.y = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Changes the position of the NPC
        newPosition.x +=
        speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
