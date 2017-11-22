using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    void Excute();
    void Enter(Enemy enemy);
    void Exit();
    void OnTriggerEnter(Collider other);
}
