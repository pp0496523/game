using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace View
{
    public class PlayerView : MonoBehaviour
    {

        Rigidbody2D _rb;
        Animator _animator;
        private SpriteRenderer _spriteRenderer;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void Move(Vector2 vector2, float moveSpeed)
        {
            float x = vector2.x;
            float _xSpeed = Math.Sign(x) * moveSpeed;
            _rb.velocity = new Vector2(_xSpeed, _rb.velocity.y);
            _animator.SetFloat("speed", Math.Abs(x));

            if (x > 0) _spriteRenderer.flipX = false;
            else if (x < 0) _spriteRenderer.flipX = true;
        }
    }
}

