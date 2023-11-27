using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float _velocity = 150f;
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
    }

    public void MoveRight()
    {
        moveRight = true;
    }

    public void Jump()
    {
        if (_rigidbody2D.velocity.y == 0) 
        {
            _rigidbody2D.velocity = Vector2.up * _velocity;
        }
    }
}
