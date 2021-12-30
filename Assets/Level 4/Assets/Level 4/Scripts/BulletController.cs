﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public int damage = 3;
 
    // Use this for initialization
    void Start () {

        controller player;
        player = FindObjectOfType<controller>();
        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
            transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }

       
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

	}
    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Enemy1")
        {
            FindObjectOfType<enemyController>().takeDamage(damage);

            Destroy(this.gameObject);
        }
        if (other.tag == "Enemy")
        {

            FindObjectOfType<enemyController>().TakeDamage(damage);
           

            Destroy(this.gameObject);
        }

        else if (other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        enemyController enemy = other.GetComponent<enemyController>();
        //if (enemy != null) {
        //    enemy.takeDamage(20);
        //}
        if (other.tag == "Enemy1")
        {
            enemy.takeDamage(damage);
            //Destroy(hitInfo.gameObject);
            Destroy(this.gameObject);
            Debug.Log(other.name);
        }
        else if (other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
    
}
