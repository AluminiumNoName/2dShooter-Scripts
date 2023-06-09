using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //��������� ������������ ������� � ������������
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� ������ �������� �����������
        if (collision.tag == "Obstacle")
        {
            //��������� �����
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    //���������� ��� �������� �������
    public float speed;

    //��������� ������ ����� 5������ ����� ������ ����
    void Start()
    {
        Destroy(gameObject, 5);
    }

    //������ �������� � ����������� ����� � ���������� ���������
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
}
