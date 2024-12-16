using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawner : MonoBehaviour
{
    public GameObject[] animals;
    public int time;
    public int repeatRate;
    private int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", time, repeatRate);
    }
    
    public void Spawner()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-42.92f, 48.1f), 5.5f, Random.Range(109.67f, 146.42f));
            int index = Random.Range(0, animals.Length);
            Instantiate(animals[index], position, transform.rotation);
        }

        spawnCount++;
    }
}
