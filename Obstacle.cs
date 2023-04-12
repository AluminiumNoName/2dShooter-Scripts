using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //описываем столкновение с препятствием
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //если коснулся игрок
        if (collision.tag == "Player")
        {
            //разрушаем игрока
            Destroy(collision.gameObject);
        }
    }
}
