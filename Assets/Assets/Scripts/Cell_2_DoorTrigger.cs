using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cell_2_DoorTrigger : MonoBehaviour
{
    [SerializeField] StatueRepaired _statueRepaired;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && _statueRepaired._statueFixed == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
