using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchBulbToSocket : MonoBehaviour
{
    [SerializeField] private GameObject _bulbInSocket;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bulb"))
        {
            _bulbInSocket.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
