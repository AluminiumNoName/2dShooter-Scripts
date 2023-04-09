using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points = 0;

    public Projectile progectilePrefab;

    public float shootCD;
    public float shootTimer;

    public Transform shootPoint;
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
    void Update()
    {
        shootTimer -= Time.deltaTime;
        Move();
        Shoot();
        
    }

    void Shoot()
    {
        if (shootTimer <= 0)
        {
            Instantiate(progectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootCD;
        }
       
    }
}
