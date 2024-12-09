using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueRepaired : MonoBehaviour
{
    [SerializeField] private GameObject[] _statuePieces;
    /*[HideInInspector] */public bool _statueFixed = false;

    private void Update()
    {
        if (_statuePieces[0].activeSelf == true && _statuePieces[1].activeSelf == true)
        {
            _statueFixed = true;
        }
    }
}
