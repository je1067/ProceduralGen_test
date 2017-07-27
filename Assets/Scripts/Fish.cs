using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {

    public float moveSpeed = 5.0f;
	
	void Start () {
		
	}
	
	
	void Update () {
        transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
        if (Random.Range(0f,100f)> 99f)
        {
            transform.Rotate(0f, Random.Range(-360f, 360f), 0f);
        }
	}
}
