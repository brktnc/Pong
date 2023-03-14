using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] AudioSource pongPaddleSFX;
    public float speed = 10;
    protected Rigidbody2D paddleRigidBody;


    private void Awake()
    {
        paddleRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            pongPaddleSFX.Play();
        }
    }

    public void ResetPositionPaddle()
    {
        paddleRigidBody.position = new Vector2(paddleRigidBody.position.x, 0.0f);
        paddleRigidBody.velocity = Vector2.zero;
    }
}
