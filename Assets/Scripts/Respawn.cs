using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Respawn : MonoBehaviour
{
    private float rCurrentY = 180f;    
  

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("deadZone"))
        {
            transform.position = GameObject.Find("RespawnPoint").transform.position; ;

            transform.rotation = Quaternion.Euler(0f, -rCurrentY, 0f);
        }
        else if (collider.gameObject.CompareTag("nextLevel"))
        {
            SceneManager.LoadScene(2);
        }
        else if (collider.gameObject.CompareTag("finishPoint"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
