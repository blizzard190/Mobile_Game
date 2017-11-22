using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_idle : IEnemyState
{
    private Enemy enemy;

    private float idleTimer;

    private float idleDuration = 5;

    public void Enter(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void Excute()
    {
        Idle();

        if (enemy.Target == null)
        {
            Idle();
        }
        if (enemy.Target != null && enemy.InMeleeRange)
        {
            enemy.ChangeState(new Enemy_mellee());
        }
       
    }

    public void Exit()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Edge")
        {
            enemy.ChangeDirection();
        }
    }

    private void Idle()
    {

        idleTimer += Time.deltaTime;

        if(idleTimer >= idleDuration)
        {
            enemy.ChangeState(new Enemy_patrol());
            idleTimer = 0;
        }
    }
}
