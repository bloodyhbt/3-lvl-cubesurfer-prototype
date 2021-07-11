using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Swerving state= new Swerving();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("eskısahne");
        }
        if (other.gameObject.tag == "Last Step")
        {
            state.StateSetter(Swerving.PlayerState.Prepare);
            Debug.Log("Oyun bitti");
        }

    }
}
