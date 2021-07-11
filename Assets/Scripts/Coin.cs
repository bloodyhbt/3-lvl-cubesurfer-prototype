using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Diamond")
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log("Your score:" + score);
        }
    }
}
