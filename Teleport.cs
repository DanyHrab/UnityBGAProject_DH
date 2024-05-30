using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        
            other.transform.position = teleportPoint.position;
        other.transform.position += new Vector3(2, 0, 2);
    
    }
}
