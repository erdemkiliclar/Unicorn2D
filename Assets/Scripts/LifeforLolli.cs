using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeforLolli : MonoBehaviour
{

    [SerializeField] float _lolliLifeTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime>_lolliLifeTime)
        {
            Destroy(this.gameObject);
        }
    }




}
