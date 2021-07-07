using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 동전이랑 물체 충돌시 점수를 1 올리고 코인 제거
        GameManager.instance.Score += 1;
        Destroy(gameObject);
    }
}
