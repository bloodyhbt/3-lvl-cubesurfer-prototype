using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swerving : MonoBehaviour
{
    [SerializeField] float forwardSpeed;
    [SerializeField] float horizontalSpeed;

    public enum PlayerState
    {
        Prepare,
        Playing,
        Died,
        Finish
    }

    [HideInInspector]
    public PlayerState playerState;


    //[SerializeField] Vector2 clampValue = new Vector2(-1, 1);

    //float horizontalAxis;

    void Start()
    {
        StateSetter(PlayerState.Prepare);
    }


    void Update()
    {
        if (playerState == PlayerState.Playing)
        {
            float horizontalAxisValue = Mathf.Clamp(Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime, -3f, +3f);
            float newZValue = forwardSpeed * Time.deltaTime;
            float newYValue = 0f;

            transform.position = new Vector3(
                                            Mathf.Clamp(transform.position.x + Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime, -4f, +4f),
                                            transform.position.y + newYValue,
                                            transform.position.z + newZValue
                                            );
        }

        if (playerState == PlayerState.Prepare)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerState = PlayerState.Playing;
                Debug.Log("Playing mode");
            }
        }
    }

    public void StateSetter(PlayerState state)
    {
        playerState = state;
    }
}
