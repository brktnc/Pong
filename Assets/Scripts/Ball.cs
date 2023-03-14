using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 200.0f;

    Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartForce();
    }

    public void AddStartForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 normal, float bounceStrength)
    {
        _rigidbody.AddForce(-normal * bounceStrength);
    }

    public void ResetBallPosition()
    {
        _rigidbody.transform.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

}
