using UnityEngine;

public class JumpBoostObject : MonoBehaviour
{
    public int jumpBoostAmount = 1; // 추가 점프 횟수를 늘릴 양
    public LayerMask playerLayerMask; // 플레이어 레이어 마스크

    private void OnTriggerEnter(Collider other)
    {
        if ((playerLayerMask.value & (1 << other.gameObject.layer)) > 0)
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.IncreaseRemainingJumps(jumpBoostAmount); // 추가 점프 횟수 증가
                gameObject.SetActive(false);
            }
        }
    }
}
