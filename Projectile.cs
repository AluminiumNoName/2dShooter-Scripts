using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
}
