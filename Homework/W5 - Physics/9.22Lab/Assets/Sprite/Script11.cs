using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour

{
    public KeyCode jumpKey;
    private Vector2 _movement;
    private Rigidbody2D _rigidbody;
    public float movementSpeed;

    void Start()
    {

        _rigidbody = gameObject.GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        if (Input.GetKeyDown(jumpKey))
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            if (Input.GetKey(KeyCode.A))
            {
                _movement.x = -1;
            }
        }

    }

    private void FixedUpdate()

    // Update 每帧刷新 FixedUpdate 定时刷新
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * movementSpeed);
    }

}