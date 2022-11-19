using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 10f;
    [SerializeField] float moveSpeed = 20f;


    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float slowSpeed = 10f;


    void Start()
    {
        
    }

    
    void Update()
    {


        float steerCount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveCount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerCount);
        transform.Translate(0, moveCount, 0);


    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "speedBoost")
        {
            moveSpeed = boostSpeed;
        }
        if(collision.tag == "slowSpeed")
        {
            moveSpeed = slowSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = 10;
    }


}
