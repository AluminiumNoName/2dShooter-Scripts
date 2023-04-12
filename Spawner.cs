using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //переменная для префаба объекта спавна
    public GameObject prefab;

    //границы карты по горризонтали
    public Transform borderR;
    public Transform borderL;

    //переменные определяющие частоту спавна объектов
    public float spawnInterval;
    public float spawnTimer;



    void Update()
    {
        //таймер считает каждый кадр
        spawnTimer -= Time.deltaTime;

        //если таймер досчитал до 0 - спавним объект
        if (spawnTimer <= 0)
        {
            Spawn();
        }
    }

    //метод, описывающий механику спавна объектов
    void Spawn()
    {
        //переемнная для рандомного расположения объектов по горизонтали
        float randomX = Random.Range(borderL.position.x, borderR.position.x);

        //переменная для положения объекта
        Vector2 newPos = transform.position;
        //меняем текущее положение по Х на рандомное
        newPos.x = randomX;

        //создаем копию префаба с учетом рандомной позиции
        Instantiate(prefab, newPos, Quaternion.identity);
        spawnTimer = spawnInterval;
    }
}
