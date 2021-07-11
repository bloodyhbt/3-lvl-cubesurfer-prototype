using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swerving : MonoBehaviour
{
    [SerializeField] float forwardSpeed;
    [SerializeField] float horizontalSpeed;


    //[SerializeField] Vector2 clampValue = new Vector2(-1, 1);

    //float horizontalAxis;

    void Start()
    {

    }


    void Update()
    {
        float horizontalAxisValue = Mathf.Clamp(Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime, -3f, +3f);
        float newZValue = forwardSpeed * Time.deltaTime;
        float newYValue = 0f;

        transform.position = new Vector3(
                                        Mathf.Clamp(transform.position.x + Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime, -3f, +3f), 
                                        transform.position.y + newYValue, 
                                        transform.position.z + newZValue
                                        );

        //horizontalAxis = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        //this.transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
        //Vector3 clampedPosition = transform.position;
        //clampedPosition.x = Mathf.Clamp(clampedPosition.x, -3f, 3f);
        //transform.position = clampedPosition;
    }
}
