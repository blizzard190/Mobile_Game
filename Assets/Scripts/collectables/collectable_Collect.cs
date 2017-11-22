using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_Collect : MonoBehaviour {

    public int scoreCount;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            scoreCount++;
        }
    }
}
