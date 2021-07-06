using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rigidbody;
    float h, v;

    // ù ��° �������� ������Ʈ ���� ȣ���
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // �� �����Ӹ���ȣ���
    void Update()
    {
        // Ű���� �Է°��� h�� v�� ����
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    // ������ Ư�� ��� �� ������Ʈ�� ó��
    private void FixedUpdate()
    {
        // Ű���� �Է°����� 3���� ���� ���� ����
        Vector3 movement = new Vector3(h, 0f, v);

        // ���Ϳ� �ӵ��� fps������� �̵��� �� �ֵ��� deltaTime�� ������
        movement *= speed * Time.deltaTime;

        // ���� ��ġ + Ű���� �Է°����� �÷��̾ �̵���Ŵ
        rigidbody.MovePosition(transform.position + movement);
    }
}
