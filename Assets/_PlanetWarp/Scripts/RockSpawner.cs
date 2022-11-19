using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public Rigidbody[] rocks;

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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
