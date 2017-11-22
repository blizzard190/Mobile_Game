using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_Hover : MonoBehaviour
{
    public float hoverHeight;
    public float sinusI = 0;
    public float startY;

	// Use this for initialization
	void Start ()
    {
        hoverHeight = 0.25f;
        startY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float yPos = Mathf.Sin(sinusI*2)*hoverHeight;
        this.transform.position = new Vector2(this.transform.position.x, startY + yPos);
        sinusI += Time.deltaTime;
    }
}
