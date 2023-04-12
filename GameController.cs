using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //переменная для скорости игры
    public static float gameSpeed;
    //ограничичиваем скорость игры диапазоном 0-5
    [Range(0, 5)]
    //текущая скорость игры
    public float gameSpeedRegulator;
    //ускорение игры
    public float speedRate = 0.5f;
    //максимальная скорость игры
    public float gameSpeedMax = 5;

    void Update()
    {
        //если скорость игры еще не максимальная
        if (gameSpeedRegulator <= gameSpeedMax)
        {
            //скорость игры увеличиаемтся на ускорение*кадры
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        //скорость игры изменяется
        gameSpeed = gameSpeedRegulator;
    }
}
