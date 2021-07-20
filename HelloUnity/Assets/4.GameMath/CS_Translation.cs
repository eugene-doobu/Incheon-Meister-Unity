using UnityEngine;

public class CS_Translation : Math_CoordinateSystem
{
    private void Update()
    {
        if (!isChild)
        {
            // 부모 오브젝트는 local과 global의 차이가 없음
            if (Input.GetKey(KeyCode.W)) tr.position += Vector3.forward * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.S)) tr.position += Vector3.back * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.A)) tr.position += Vector3.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.D)) tr.position += Vector3.left * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.Q)) tr.position += Vector3.up * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.E)) tr.position += Vector3.down * speed * Time.deltaTime;
        }
        else
        {
            // Pos
            if (!isLocal && Input.GetKey(KeyCode.W)) childTr.position += Vector3.forward * speed * Time.deltaTime;
            if (!isLocal && Input.GetKey(KeyCode.S)) childTr.position += Vector3.back * speed * Time.deltaTime;
            if (!isLocal && Input.GetKey(KeyCode.A)) childTr.position += Vector3.right * speed * Time.deltaTime;
            if (!isLocal && Input.GetKey(KeyCode.D)) childTr.position += Vector3.left * speed * Time.deltaTime;
            if (!isLocal && Input.GetKey(KeyCode.Q)) childTr.position += Vector3.up * speed * Time.deltaTime;
            if (!isLocal && Input.GetKey(KeyCode.E)) childTr.position += Vector3.down * speed * Time.deltaTime;

            // localPos
            if (isLocal && Input.GetKey(KeyCode.W)) childTr.localPosition += Vector3.forward * speed * Time.deltaTime;
            if (isLocal && Input.GetKey(KeyCode.S)) childTr.localPosition += Vector3.back * speed * Time.deltaTime;
            if (isLocal && Input.GetKey(KeyCode.A)) childTr.localPosition += Vector3.right * speed * Time.deltaTime;
            if (isLocal && Input.GetKey(KeyCode.D)) childTr.localPosition += Vector3.left * speed * Time.deltaTime;
            if (isLocal && Input.GetKey(KeyCode.Q)) childTr.localPosition += Vector3.up * speed * Time.deltaTime;
            if (isLocal && Input.GetKey(KeyCode.E)) childTr.localPosition += Vector3.down * speed * Time.deltaTime;
        }
    }
}
