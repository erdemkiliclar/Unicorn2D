using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float _jumpSpeed;
    [SerializeField] bool _isActive;
    Rigidbody2D _rigidbody2D;
    MoverController _moveController;




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isActive = true;
        }
        
    }

    private void Awake()
    {
        _moveController = new MoverController();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        if (_isActive)
        {
            Jump();
        }
        _isActive = false;
    }

    void Jump()
    {
        _moveController.JumpAxis(_rigidbody2D, _jumpSpeed, _isActive);

    }
}
