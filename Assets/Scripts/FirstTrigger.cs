using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstTrigger : MonoBehaviour
{

    public GameObject spawnBall;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Spike" || other.gameObject.name == "Spike (1)" || other.gameObject.name == "Spike (2)" || other.gameObject.name == "Spike (3)" || other.gameObject.name == "Spike (4)" || other.gameObject.name == "Spike (5)" || other.gameObject.name == "Spike (6)")
        {
            Destroy(spawnBall);
            SceneManager.LoadScene (1);
        }

        if(other.gameObject.name == "FinalFlag")
        {
            SceneManager.LoadScene (0);
        }

    }

}
