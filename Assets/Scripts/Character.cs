using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected float Speed;

    [SerializeField]
    protected int healt;

    public abstract bool IsDead { get; }

    protected bool facingRight;

    public bool Attack { get; set; }
    
    public virtual void Start()
    {
        facingRight = true;
    }

    public void ChangeDirection()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
    }

    public abstract IEnumerator TakeDamge();

    public virtual void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            StartCoroutine(TakeDamge());
        }
    }
}
