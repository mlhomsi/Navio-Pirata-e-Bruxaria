using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    //public AudioSource passos;
    bool isMoving;

    private Vector2 adjustOperation;

   // public Animator playerMov;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        if (inputX != 0 && inputY != 0) {
        }
       // playerMov.SetFloat("VelX", inputX);
       // playerMov.SetFloat("VelY", inputY);

        adjustOperation = new Vector2(inputX * speed, inputY * speed);
        adjustOperation.Normalize();
        rb.velocity = adjustOperation*speed;
    }
}
