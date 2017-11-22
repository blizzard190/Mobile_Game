using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_mellee : IEnemyState
{
    private Enemy enemy;

    private float attackTimer;
    private float attackCoolDown = 3;
    private bool canAttack = true;

    public void Enter(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void Excute()
    {
            Attack();
        if (enemy.Target != null)
        {
            enemy.Move();
        }

        if (enemy.Target == null)
        {
            enemy.ChangeState(new Enemy_idle());
        }
    }

    public void Exit()
    {
             
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Edge")
        {
            enemy.Target = null;
            enemy.ChangeDirection();
        }
    }

    private void Attack()
    {
        attackTimer += Time.deltaTime;

        //if(attackTimer <= attackCoolDown)
        //{
        //    enemy.MyAnimator.ResetTrigger("attack");
        //}

        if(attackTimer >= attackCoolDown)
        {
            canAttack = true;
            attackTimer = 0;
        }

        if (canAttack)
        {
            canAttack = false;
        }
    }
}
