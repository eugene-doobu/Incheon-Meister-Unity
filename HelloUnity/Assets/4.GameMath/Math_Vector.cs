using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math_Vector : MonoBehaviour
{
    void Start()
    {
        // ����
        Vector2 vector2_ = new Vector2(x: 1, y: 1);
        Vector3 vector3_ = new Vector3(x: 1, y: 1, z: 1);
        Vector4 vector4_ = new Vector4(x: 1, y: 1, z: 1, w: 1);

        // ������ �ӱ�
        Vector3 rightVec = Vector3.right; // 1, 0, 0
        Vector3 upVec = Vector3.up; // 0, 1, 0
        Vector3 forwardVec = Vector3.forward; // 0, 0, 1

        // ������ ����
        Vector3 sumA = new Vector3(2, 0, 4);
        Vector3 sumB = new Vector3(0, 3, 0);
        Debug.Log("sum: " +(sumA + sumB)); // 2, 3, 4

        // ������ ����
        // A - B �� 'B���� A������ ����� �Ÿ�'�� �ǹ��Ѵ�.
        Vector3 subA = new Vector3(1, 0, 0);
        Vector3 subB = new Vector3(0, 0, 1);
        Debug.Log("sub: " + (subA - subB)); // 1, 0, -1
        // subB���͸� (1, 0, -1) ��ŭ �̵���Ű�� subA�� ���� ���Ͱ� �ȴ�.

        // ������ ��Į�� ��
        Vector3 scalarMul = new Vector3(1, 2, 3);
        Debug.Log("mul: " + (scalarMul * 3)); // 3, 6, 9

        // ������ ũ��
        // ��Ÿ����� ���� �̿�
        Vector2 mag = new Vector2(1, 1);
        Debug.Log("mag1: " + Mathf.Sqrt(mag.x * mag.x + mag.y * mag.y));
        Debug.Log("mag2: " + mag.magnitude);

        // ������ ����ȭ
        // ��������: ũ�Ⱑ 1�� ����(����ȭ�� ����)
        // ������ ���� ��ü�� ��Ÿ��
        Vector2 normalize = new Vector2(3, 5);
        Debug.Log("normalized1: " + (normalize / normalize.magnitude));
        Debug.Log("normalized2: " + normalize.normalized);

        // ������ ����
        // ������ ������ ����� ��Į��

        // ���͸� �����ϴ� ����
        // A dot B�� ���� B�� A�� ������� ����

        // ���� ������ ������ ���ϴµ� �̿�
        // �ʿ��Լ� ����� ���ϴ� ���� ��õ
        Vector2 dotA = new Vector2(0, 2);
        Vector2 dotB = new Vector2(3, 3);
        Debug.Log("Dot1: " + (dotA.x * dotB.x + dotA.y * dotB.y));
        Debug.Log("Dot2: " + (dotA.magnitude * dotB.magnitude * Mathf.Cos(45 * Mathf.Deg2Rad)));
        Debug.Log("Dot3: " + Vector2.Dot(dotA, dotB));

        // ������ ����
        // �� ���͸� ��� �������� ����ϴ� ���͸� ���ϴ� ����
        // � ǥ�鿡 ������ ����(�븻 ����)�� ���� �� ����
        Vector3 crossA = new Vector3(1, 0, 0);
        Vector3 crossB = new Vector3(0, 0, 1);
        Debug.Log("AxB: " + Vector3.Cross(crossA, crossB));
        Debug.Log("BxA: " + Vector3.Cross(crossB, crossA));

        // ���ʹϾ�
        // ȸ���� �̿�
        Quaternion quaternion = new Quaternion(x: 1, y: 1, z: 1, w: 1); // ȸ���� ǥ��

        // ���������� �����ϱ� ����� ������ ���Ϸ�-���ʹϾ� ��ȯ�� �ַ� ���
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 45, 0));
        Vector3 eulerRotation = rotation.eulerAngles;
        Debug.Log("eToq: " + rotation);
        Debug.Log("qToe: " + eulerRotation);

        Quaternion a = Quaternion.Euler(30, 0, 0); // 0.0, 0.4, 0.0, 0.9
        Quaternion b = Quaternion.Euler(0, 0, 60); // 0, 45, 0

        // a��ŭ ȸ�� �� b��ŭ ȸ����Ű�� ���ʹϾ�
        Quaternion rotationProduct = a * b;
        Debug.Log("q*q: " + rotationProduct); // 0.2, -0.1, 0.5, 0.8

        // ���
        // ���� ����(���� ��ȯ)�� �̿�
        Matrix4x4 m = new Matrix4x4(vector4_, vector4_, vector4_, vector4_);
        Debug.Log("mat4x4 :\n" + m); // 1�� ������ 4x4 ���

        Vector3 trs_pos = new Vector3(5, 0, 0); // x������ 5��ŭ �����̵�
        Quaternion trs_rot = Quaternion.Euler(new Vector3(0, 90, 0)); // y������ 90�� ȸ��
        Vector3 trs_scale = new Vector3(2, 2, 2); // ������ 2��
        Matrix4x4 trs = Matrix4x4.TRS(trs_pos, trs_rot, trs_scale);

        Vector4 obj = trs * Vector4.one;
        Debug.Log("trs : " + obj); // 7, 2, -2, 1

        obj = trs.inverse * obj;
        Debug.Log("trs inverse: " + obj); // 1, 1, 1, 1
    }
}
