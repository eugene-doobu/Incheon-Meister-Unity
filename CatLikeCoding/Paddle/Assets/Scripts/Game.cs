using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]          private Ball    ball;
    [SerializeField]          private Paddle  bottomPaddle, topPaddle;
    [SerializeField, Min(0f)] private Vector2 arenaExtents = new Vector2(10f, 10f);

    private void Awake()
    {
        ball.StartNewGame();
    }

    private void Update()
    {
        bottomPaddle.Move(ball.Position.x, arenaExtents.x);
        topPaddle.Move(ball.Position.x, arenaExtents.x);
        ball.Move();
        BounceYIfNeeded();
        BounceXIfNeeded(ball.Position.x);
        ball.UpdateVisualization();
    }

    void BounceYIfNeeded()
    {
        float yExtents = arenaExtents.y - ball.Extents;
        if (ball.Position.y < -yExtents)
        {
            BounceY(-yExtents, bottomPaddle);
        }
        else if (ball.Position.y > yExtents)
        {
            BounceY(yExtents, topPaddle);
        }
    }

    void BounceY(float boundary, Paddle defender)
    {
        var durationAfterBounce = (ball.Position.y - boundary) / ball.Velocity.y;
        var bounceX = ball.Position.x - ball.Velocity.x * durationAfterBounce;
        
        BounceXIfNeeded(bounceX);
        bounceX = ball.Position.x - ball.Velocity.x * durationAfterBounce;
        ball.BounceY(boundary);
        
        if(defender.HitBall(bounceX, ball.Extents, out float hitFactor))
        {
            ball.SetXPositionAndSpeed(bounceX, hitFactor, durationAfterBounce);
        }
    }
    
    void BounceXIfNeeded(float x)
    {
        float xExtents = arenaExtents.x - ball.Extents;
        if (x < -xExtents)
        {
            ball.BounceX(-xExtents);
        }
        else if (x > xExtents)
        {
            ball.BounceX(xExtents);
        }
    }
}
