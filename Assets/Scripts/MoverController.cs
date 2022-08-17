using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : IMover
{

    

    public float Jump => Input.GetAxis("Jump");

    public void JumpAxis(Rigidbody2D _rigidbody2D,float _jSpeed, bool _jisActive) 
    {
        _rigidbody2D.AddForce(Vector2.up * _jSpeed * Jump);
    }




}
