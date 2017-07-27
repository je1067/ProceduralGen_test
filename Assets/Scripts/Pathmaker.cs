using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathmaker : MonoBehaviour {

    private int Counter = 0;
    public static int tileGlobalCount = 0;
    public Transform floorPrefab;
    public Transform floorPrefab_Red;
    public Transform floorPrefab_Green;
    public Transform floorPrefab_Brown;
    public Transform pathmakerSpherePrefab;
    

	
	void Start () {
        
	}


    void Update()
    {
        if (Counter < 500)
        {
            float randomNumber = Random.Range(0.0f, 1.0f);
            if (randomNumber < 0.25f)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            else if (randomNumber < 0.5f)
            {
                transform.Rotate(0f, -90f, 0f);
            }
            else if (randomNumber > 0.98f)
            {
                Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
            }
            if (randomNumber < .3)
            {
                Instantiate(floorPrefab, transform.position, Quaternion.identity);
                transform.Translate(0f, 0f, 10f);
                Counter += 1;
                tileGlobalCount += 1;
            }
            if (randomNumber < .5)
            {
                Instantiate(floorPrefab_Green, transform.position, Quaternion.identity);
                transform.Translate(0f, 0f, 10f);
                Counter += 1;
                tileGlobalCount += 1;
            }
            if (randomNumber < .9)
            {
                Instantiate(floorPrefab_Brown, transform.position, Quaternion.identity);
                transform.Translate(0f, 0f, 10f);
                Counter += 1;
                tileGlobalCount += 1;
            }
            else
            {
                Instantiate(floorPrefab_Red, transform.position, Quaternion.identity);
                transform.Translate(0f, 0f, 10f);
                Counter += 1;
                tileGlobalCount += 1;
            }
            
        }
        else
        {
            Destroy(gameObject);
        }
        if (tileGlobalCount > 500)
        {
            Destroy(gameObject);
        }
    }
}
