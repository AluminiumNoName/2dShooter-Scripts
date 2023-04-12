using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    //описываем столкновение с предметом сбора
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //если коснулся игрок
        if (collision.tag == "Player")
        {
            //создаем переменную для компонента Player, который содержит очки игрока
            Player player = collision.GetComponent<Player>();
            //дорисовываем игроку очки
            player.points++;
            //разрушаем предмет
            Destroy(gameObject);
        }
    }
}
