using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField, Min(0f)] private float
        extents = 4f,
        speed   = 10f;

    [SerializeField] private bool isAi;

    public void Move(float target, float arenaExtents)
    {
        var p = transform.localPosition;
        p.x = isAi ? AdjustByAI(p.x, target) : AdjustByPlayer(p.x);
        var limit = arenaExtents - extents;
        p.x = Mathf.Clamp(p.x, -limit, limit);
        transform.localPosition = p;
    }

    float AdjustByAI(float x, float target)
    {
        if (x < target)
        {
            return Mathf.Min(x + speed * Time.deltaTime, target);
        }
        return Mathf.Min(x - speed * Time.deltaTime, target);
    }
    
    float AdjustByPlayer(float x)
    {
        bool goRight = Input.GetKey(KeyCode.RightArrow);
        bool goLeft  = Input.GetKey(KeyCode.LeftArrow);
        if (goRight && !goLeft)
        {
            return x + speed * Time.deltaTime;
        }
        if (goLeft && !goRight)
        {
            return x - speed * Time.deltaTime;
        }
        return x;
    }
}
