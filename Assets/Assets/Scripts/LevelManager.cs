using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int Currentlevel;

    [SerializeField] private float transitionTime = 1f;

    [SerializeField] private GameObject playerCharacter;

    private void Start()
    {
        if (playerCharacter == null)
        {
            Debug.Log(playerCharacter + " is not found.");
        }
    }

    private void Update()
    {

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
