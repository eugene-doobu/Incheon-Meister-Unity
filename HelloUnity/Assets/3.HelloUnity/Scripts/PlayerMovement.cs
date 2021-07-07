using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;
    float h, v;

    // 첫 번째 프레임의 업데이트 전에 호출됨
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // 매 프레임마다호출됨
    void Update()
    {
        // 키보드 입력값을 h와 v에 저장
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    // 물리적 특성 계산 및 업데이트를 처리
    private void FixedUpdate()
    {
        // 키보드 입력값으로 3차원 벡터 값을 생성
        Vector3 movement = new Vector3(h, 0f, v);

        // 벡터에 속도와 fps상관없이 이동할 수 있도록 deltaTime을 곱해줌
        movement *= speed * Time.deltaTime;

        // 현재 위치 + 키보드 입력값으로 플레이어를 이동시킴
        rb.MovePosition(transform.position + movement);
    }
}
