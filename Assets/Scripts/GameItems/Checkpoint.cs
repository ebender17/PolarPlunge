using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Checkpoint trigger entered!");
        GameController gc = other.gameObject.GetComponent<GameController>();
        if(gc != null)
        {
            gc.CurrentCheckpoint = transform.position;
        }

    }
}
