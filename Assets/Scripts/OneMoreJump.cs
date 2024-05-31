using UnityEngine;

public class JumpBoostObject : MonoBehaviour
{
    public int jumpBoostAmount = 1; // �߰� ���� Ƚ���� �ø� ��
    public LayerMask playerLayerMask; // �÷��̾� ���̾� ����ũ

    private void OnTriggerEnter(Collider other)
    {
        if ((playerLayerMask.value & (1 << other.gameObject.layer)) > 0)
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.IncreaseRemainingJumps(jumpBoostAmount); // �߰� ���� Ƚ�� ����
                gameObject.SetActive(false);
            }
        }
    }
}
