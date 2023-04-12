using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //описываем столкновение снар€да с преп€тствием
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //если снар€д коснулс€ преп€тстви€
        if (collision.tag == "Obstacle")
        {
            //разрушаем обоих
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    //переменна€ дл€ скорости сн€р€да
    public float speed;

    //разрушаем объект через 5секунд после начала игры
    void Start()
    {
        Destroy(gameObject, 5);
    }

    //объект движетс€ в направлении вверх с посто€нной скоростью
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
}
