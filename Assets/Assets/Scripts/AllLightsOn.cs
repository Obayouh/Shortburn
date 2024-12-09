using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLightsOn : MonoBehaviour
{
    [SerializeField] private GameObject[] _lightsOn;
    [HideInInspector] public bool _bulbsOn = false;

    void Update()
    {
        if (_lightsOn[0].activeSelf == true && _lightsOn[1].activeSelf == true && _lightsOn[2].activeSelf == true && _lightsOn[3].activeSelf == true)
        {
            _bulbsOn = true;
        }
    }
}
