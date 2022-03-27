using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private int hp = 10;

    private GameObject player;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          if ((player.transform.position.y - transform.position.y) >= (player.transform.position.x - transform.position.x))
        {
            RunV();
        } else
        {
            RunH();
        }
    }

    private void RunV()
    {
        Vector3 dir = transform.up * player.transform.position.y * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }

    private void RunH()
    {
        Vector3 dir = transform.right * player.transform.position.x * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
}

