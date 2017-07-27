using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGod_ : MonoBehaviour {

    public Fish fishPrefab;

	void Start () {
		
	}

    void Update() {

        if (Input.GetKeyDown(KeyCode.F)) {
            Fish newFishClone = Instantiate(fishPrefab, Vector3.zero, Quaternion.identity);
            newFishClone.moveSpeed = Random.Range(1f, 10f);
            newFishClone.transform.localScale *= Random.Range(0.1f, 3f);
        } 

    }
}
