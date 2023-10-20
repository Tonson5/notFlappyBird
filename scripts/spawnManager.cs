using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject spawn;
    public GameObject obstacle;
    private playerController playerController;
    
    void Start()
    {
        InvokeRepeating("Spawn", 0, 3);
    }

 
    void Update()
    {
        playerController = GameObject.Find("player").GetComponent<playerController>();
    }
    void Spawn()
    {
   if (playerController.isDead == false) 
        {
            Vector3 randomSpawn = new Vector3(spawn.transform.position.x, Random.Range(1, 10), spawn.transform.position.z);

            Instantiate(obstacle, randomSpawn, transform.rotation);
        }
    }
}
