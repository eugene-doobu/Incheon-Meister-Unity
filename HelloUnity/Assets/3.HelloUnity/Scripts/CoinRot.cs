using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRot : MonoBehaviour
{
    public float speed = 5f;
    Transform tr;

    private void Awake()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        // 1초당 speed각도(deg)만큼 회전
        tr.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
