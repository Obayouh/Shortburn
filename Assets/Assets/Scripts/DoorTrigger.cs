using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] AllLightsOn _allLightsOn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && _allLightsOn._bulbsOn == true)
        {
            SceneManager.LoadScene(1);
        }
    }
}
