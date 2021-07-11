using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D enemy;

    // Start is called before the first frame update
    void Awake()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy.velocity = new Vector2(speed, enemy.velocity.y);
    }
}
