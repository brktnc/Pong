using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bouncyStrength;

    [SerializeField] AudioSource bounceSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            bounceSFX.Play();
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(normal, bouncyStrength);
        }
    }
}
