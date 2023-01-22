using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace View
{
    public class PlayerView : MonoBehaviour
    {

        Rigidbody2D _rb;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 vector2, float moveSpeed)
        {
            float _xSpeed = Math.Sign(vector2.x) * moveSpeed;
            _rb.velocity = new Vector2(_xSpeed, _rb.velocity.y);
        }
    }
}

