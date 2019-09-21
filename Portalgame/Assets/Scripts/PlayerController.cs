using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float screenWidth = Screen.width; //camel case
    private float addSpeed; //pascal case

    void Start()
    {
        addSpeed = 0;
    }

    void Update()    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1.5)
            transform.position -= Vector3.right * 1f;
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 1.5)
            transform.position -= Vector3.right * 1f;

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).position.x < screenWidth / 2
                 && Input.GetTouch(i).phase == TouchPhase.Ended
                 && transform.position.x > -1.5f)
            {
                transform.position -= Vector3.right * 1f;
            }

            if (Input.GetTouch(i).position.x < screenWidth / 2
                 && Input.GetTouch(i).phase == TouchPhase.Ended
                 && transform.position.x < 1.5f)
            {
                transform.position += Vector3.right * 1f;
            }
        }
    }
}
