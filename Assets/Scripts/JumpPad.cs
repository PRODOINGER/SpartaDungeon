using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;  // �������� ���� Ƣ������� �� ũ��

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� �÷��̾����� Ȯ��
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // �÷��̾��� Rigidbody�� �ִٸ� �������� ���� ����
            if (playerRigidbody != null)
            {
                Vector3 force = Vector3.up * jumpForce;
                playerRigidbody.AddForce(force, ForceMode.Impulse);
            }
        }
    }
}

