using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAgain_Button : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
    }
}
