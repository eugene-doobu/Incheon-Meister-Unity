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
    
    // w: �� (z)
    // s: �� (-z)
    // a: ���� (-x)
    // d: ������ (x)
    // q: �� (y)
    // e: �Ʒ� (-y)
}
