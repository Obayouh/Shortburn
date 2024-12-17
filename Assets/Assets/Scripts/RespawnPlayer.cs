using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    //[SerializeField] private LevelManager levelManager;

    [HideInInspector] public Vector3 _PublicRespawnPoint;

    private Vector3 _RespawnPoint;
    private Vector3 currentCheckpointRespawn;

    private Coroutine currentCoroutine;

    void Start()
    {
        transform.position = _RespawnPoint;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillPlane") && currentCoroutine == null)
        {
             RestartLife();
            currentCoroutine = StartCoroutine(EWait());
        }

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            currentCheckpointRespawn = other.gameObject.transform.position;
            _RespawnPoint = currentCheckpointRespawn;
            Destroy(other.gameObject.GetComponent<BoxCollider>());
        }
    }

    public Vector3 ReturnRespawnPoint()
    {
        Debug.Log("not filled in");
        _PublicRespawnPoint = _RespawnPoint;
        return _PublicRespawnPoint;
    }

    private void RestartLife()
    {
        transform.position = _RespawnPoint;
    }
    IEnumerator EWait()
    {
        yield return new WaitForSeconds(2f);
        currentCoroutine = null;
    }
}
