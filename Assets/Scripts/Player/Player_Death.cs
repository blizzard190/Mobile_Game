using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Death : MonoBehaviour {

	void Update ()
    {
        GameObject _bottomPoint = GameObject.Find("BottomPoint");
        if (gameObject.transform.position.y <= _bottomPoint.transform.position.y)
        {
            DestroyObject(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Death"))
        {
            DestroyObject(gameObject);
        }
    }
}
