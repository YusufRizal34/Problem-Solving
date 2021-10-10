using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;

    public float speed = 5f;
    private float horizontalMovement;
    private float verticalMovement;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        horizontalMovement  = Input.GetAxis("Horizontal");
        verticalMovement    = Input.GetAxis("Vertical");

        Move(horizontalMovement, verticalMovement);
    }

    private void Move(float x, float y){
        movement.Set(x, y);
        movement = movement.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}