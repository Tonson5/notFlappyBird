using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    private playerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isDead == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 30);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
