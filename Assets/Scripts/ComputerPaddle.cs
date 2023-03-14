using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0.0f && ball.transform.position.x > 0.0f)
        {
            if (paddleRigidBody.transform.position.y > ball.transform.position.y)
            {
                paddleRigidBody.AddForce(Vector2.down * this.speed);
            }
            else if (paddleRigidBody.transform.position.y < ball.transform.position.y)
            {
                paddleRigidBody.AddForce(Vector2.up * this.speed);
            }
        }
        else
        {
            if (paddleRigidBody.transform.position.y > 0.0f)
            {
                paddleRigidBody.AddForce(Vector2.down * this.speed);
            }
            else if (paddleRigidBody.transform.position.y < 0.0f)
            {
                paddleRigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
