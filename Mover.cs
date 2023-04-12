using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //переменная для чистой скорости объекта
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //разрушаем объект через 5секунд после начала игры
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //объект движется в направлении вниз с постоянной скоростью, учитывая скорость игры
        transform.position = (Vector2)transform.position + Vector2.down * (speed+GameController.gameSpeed) * Time.deltaTime;
    }
}
