using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalindex = Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalindex], new Vector3(0, 0, 20), animalPrefabs[animalindex].transform.rotation);
        }
    }
}
