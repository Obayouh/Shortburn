using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteStatue : MonoBehaviour
{
    [SerializeField] private GameObject _firstStatuePiece;
    [SerializeField] private GameObject _secondStatuePiece;
    private bool _firstPieceAdded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StatuePiece") && _firstPieceAdded == false)
        {
            _firstStatuePiece.SetActive(true);
            _firstPieceAdded = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("StatuePiece") && _firstPieceAdded == true)
        {
            _secondStatuePiece.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
