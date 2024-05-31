using UnityEngine;
using System.Collections;

public class JumpBoostSpawner : MonoBehaviour
{
    public GameObject oneMoreJumpPrefab; // JumpBoostObject�� ������
    public Transform spawnPoint; // ������Ʈ�� ������ ��ġ
    public float spawnInterval = 5f; // ���� ���� (��)

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