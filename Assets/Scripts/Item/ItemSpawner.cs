using UnityEngine;
using System.Collections;

public class JumpBoostSpawner : MonoBehaviour
{
    public GameObject oneMoreJumpPrefab; // JumpBoostObject의 프리팹
    public Transform spawnPoint; // 오브젝트가 생성될 위치
    public float spawnInterval = 5f; // 생성 간격 (초)

    private void Start()
    {
        StartCoroutine(SpawnOneMoreJumpObject());
    }

    private IEnumerator SpawnOneMoreJumpObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Debug.Log("1");

            if (!oneMoreJumpPrefab.activeInHierarchy)
            {
                Debug.Log("2");
                oneMoreJumpPrefab.SetActive(true);
                Debug.Log("3");
            }
        }
    }
}