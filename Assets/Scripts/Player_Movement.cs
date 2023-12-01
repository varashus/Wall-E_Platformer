using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float _velocity = 15f;
    [SerializeField] private float _speed = 1.00001f;
    private Rigidbody2D _rigidbody2D;

    private bool moveLeft, moveRight;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        moveLeft = true;
        _rigidbody2D.velocity = new Vector2(-1 * _velocity * _speed, _rigidbody2D.velocity.y);
    }

    public void MoveRight()
    {
        moveRight = true;
        _rigidbody2D.velocity = new Vector2(_velocity * _speed, _rigidbody2D.velocity.y);
    }

    public void MoveStop()
    {
        _rigidbody2D.velocity = new Vector2(0, _rigidbody2D.velocity.y);
    }

    public void Jump()
    {
        if (_rigidbody2D.velocity.y == 0) 
        {
            _rigidbody2D.velocity = Vector2.up * _velocity;
        }
    }
}
