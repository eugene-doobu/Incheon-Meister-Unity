using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math_CoordinateSystem : MonoBehaviour
{
    public bool isLocal;
    public bool isChild;
    protected Transform tr;
    protected Transform childTr;
    public float speed = 1;

    void Start()
    {
        tr = GetComponent<Transform>();
        childTr = tr.Find("Sphere");
    }
    
    // w: 앞 (z)
    // s: 뒤 (-z)
    // a: 왼쪽 (-x)
    // d: 오른쪽 (x)
    // q: 위 (y)
    // e: 아래 (-y)
}
