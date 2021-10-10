using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void Start() {
        rb.AddForce(new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)));
    }

    private void Update() {
        if(GameManager.score % 10 == 0 && GameManager.score != 0){
            rb.AddForce(new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)));
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            GameManager.score--;
        }
    }
}
