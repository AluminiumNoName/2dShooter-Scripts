using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //переменная для очков игрока
    public int points = 0;

    //переменная лоя снаряда игрока
    public Projectile progectilePrefab;

    //переменные для перезарядки
    public float shootCD;
    public float shootTimer;

    //переменная для точки выстрела
    public Transform shootPoint;
    //метод, описывающий движение корабля игрока
    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
        //создаем переменну типа Vector2 для положения курсора
        Vector2 mousePos = Input.mousePosition;
        //переводим координаты из локальных (экран) в глобальные (сцена)
        Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = realPos;
        }
      
    }
    //метод, описывающий поведение корабля во время игры
    void Update()
    {
        //постоянная перезарядка
        shootTimer -= Time.deltaTime;
        //двигаемся
        Move();
        //и стреляем
        Shoot();
        
    }

    //переемнная, описывающая механизм стрельбы
    void Shoot()
    {
        if (shootTimer <= 0)
        {
            //создем копию префаба снаряда, в точке выстрела, с изначальным поворотом
            Instantiate(progectilePrefab, shootPoint.position, Quaternion.identity);
            //обнуляем кулдаун
            shootTimer = shootCD;
        }
       
    }
}
