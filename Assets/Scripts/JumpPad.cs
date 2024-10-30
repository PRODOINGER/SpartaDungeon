using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;  // 점프대의 위로 튀어오르는 힘 크기

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트가 플레이어인지 확인
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // 플레이어의 Rigidbody가 있다면 위쪽으로 힘을 가함
            if (playerRigidbody != null)
            {
                Vector3 force = Vector3.up * jumpForce;
                playerRigidbody.AddForce(force, ForceMode.Impulse);
            }
        }
    }
}

