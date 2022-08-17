using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class LolliScript : MonoBehaviour
{
    [SerializeField] float _leftSpeed;

    Rigidbody2D _lolliRigid2D;

    private void Awake()
    {
        _lolliRigid2D = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        LolliMove();
    }

    void LolliMove()
    {

        _lolliRigid2D.velocity=Vector2.left * _leftSpeed * Time.deltaTime;
    }

}
