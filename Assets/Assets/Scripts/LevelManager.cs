using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int Currentlevel;

    [SerializeField] private float transitionTime = 1f;

    private Vector3 _RespawnPoint;
    private Coroutine currentCoroutine;

    [SerializeField] private GameObject playerCharacter;

    private RespawnPlayer respawnPlayerScript;

    private void Start()
    {
        respawnPlayerScript = FindObjectOfType<RespawnPlayer>();
        if (respawnPlayerScript != null)
        {
            _RespawnPoint = respawnPlayerScript.transform.position;
        }

        if (playerCharacter == null)
        {
            Debug.Log(playerCharacter + " is not found.");
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.G) && currentCoroutine == null)
    //    {
    //        RestartLife();
    //        currentCoroutine = StartCoroutine(EPreventSpam());

    //    }
    //}

    private void RestartLife()
    {
        if (CheckpointRegister() == null)
        {
            transform.position = _RespawnPoint;
        }
    }

    public Vector3 ReturnRespawnPoint()
    {
        Debug.Log("not filled in");
        return _RespawnPoint;
    }

    public Vector3 CheckpointRegister()
    {
        Vector3 currentCheckpointRespawn = new Vector3();
        Vector3 newCheckpointRespawn = new Vector3();

        if (currentCheckpointRespawn == null)
        {
            currentCheckpointRespawn = _RespawnPoint;
        }
        else if (currentCheckpointRespawn != null)
        {
            currentCheckpointRespawn = newCheckpointRespawn;
        }

        return currentCheckpointRespawn;
    }
    IEnumerator EPreventSpam()
    {

        yield return new WaitForSeconds(2f);
        currentCoroutine = null;
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
