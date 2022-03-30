using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public int health;
    public float speed;
    public int damage;
    private Player player;
    // public AudioSource DeathSound;
    
    private void Start()
    {
        player = FindObjectOfType<Player>();
       // DeathSound = player.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(health <= 0 )
        {   
            
            Destroy(gameObject);
           // DeathSound.Play();
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(timeBtwAttack <= 0)
            {
               OnEnemyAttack();
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
        }
    }
    public void OnEnemyAttack()
    {
        player.health -= damage;
        timeBtwAttack = startTimeBtwAttack;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        timeBtwAttack = startTimeBtwAttack;
    }
}
