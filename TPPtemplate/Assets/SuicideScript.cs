using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.5f ;
    public Transform playerLoaction;
    
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //need to change the " set active " to health system.
            player.SetActive(false);
            //make the enemy disapear .
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //make the object move towards the player .
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed*Time.deltaTime);
        //make the object face the player .
        transform.LookAt(playerLoaction);
    }
}
