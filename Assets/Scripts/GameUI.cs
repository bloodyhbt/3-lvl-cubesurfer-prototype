using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Image levelSlider;
    public Image currentLevelImg;
    public Image nextLevelImg;

    public GameObject player;
    public GameObject homeUI;

    void Start()
    {
        
        //levelSlider.transform.parent.GetComponent<Image>().color = Color.green + Color.white;
        //levelSlider.color = Color.green;
        //currentLevelImg.color = Color.green;
        //nextLevelImg.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Swerving>().playerState != Swerving.PlayerState.Prepare)
        {
            homeUI.SetActive(false);
           // Debug.Log("Buras� da �al���yo");
        }
    }

}
