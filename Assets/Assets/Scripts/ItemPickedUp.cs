using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickedUp : MonoBehaviour
{
    private Vector3 _startPos;
    public bool _isMoving = false;

    void Start()
    {
        _startPos = this.gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        if (this.gameObject.transform.position != _startPos)
        {
            _isMoving = true;
        }

        if (_isMoving == true)
        {

        }
    }
}