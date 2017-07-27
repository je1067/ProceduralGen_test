using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassPlanter : MonoBehaviour {

    public Transform grassPrefab;


	void Start () {
        int grassCounter = 0;

        while (grassCounter < 500)
        {

            Instantiate(grassPrefab, new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 4f)),
                Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
            grassCounter++;
        }
	}
	
	
	void Update () {
		
	}
}
