using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    public Camera mainCamera;

    public float speed = 5f;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        Move(mainCamera.ScreenToWorldPoint(Input.mousePosition));
    }

    private void Move(Vector3 position){
        position.z = 0f;
        if(transform.position != position){
            movement.Set(position.x, position.y);
            movement = movement.normalized * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + movement);
        }
    }
}