using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public Rigidbody[] rocks; //set in game engine

    public GameObject[] rockObjects;

    public string[] rockNames = {"iron", "nickel", "sulfur"};

    // Start is called before the first frame update
    void Start()
    {
      for (int i = 0; i < 50; i++)
      {
        for (int j = 0; j < rocks.Length; j++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 1000), 75, Random.Range(-1000, 0));
            Rigidbody newRock = rocks[j];
            newRock.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            Instantiate(newRock, randomSpawnPosition, Quaternion.identity);
        }
      }

      // spawn rocks that are part of the game
      int x = 440;
      int z = -440;
      for (int j = 0; j < rockNames.Length; j++)
      {
            //Vector3 randomSpawnPosition = new Vector3(Random.Range(200, 800), 75, Random.Range(-800, -200));
            Vector3 randomSpawnPosition = new Vector3(x, 100, z);
            GameObject newRock = rockObjects[j];
            rockObjects[j] = Instantiate(newRock, randomSpawnPosition, Quaternion.identity);
            rockObjects[j].name = rockNames[j];
            x = x+30;
            z = z+20;
      }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
