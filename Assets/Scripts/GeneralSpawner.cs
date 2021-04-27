using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpawner : MonoBehaviour
{
   
    public GameObject objectToSpawn;
    private float frequencyOfSpawnInSeconds = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1, frequencyOfSpawnInSeconds);
    }

    private void SpawnObject()
    {
        GameObject ObjectToSpawn = Instantiate<GameObject>(objectToSpawn);
        ObjectToSpawn.transform.position = transform.position;
    }

}
