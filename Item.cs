using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    //��������� ������������ � ��������� �����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� �������� �����
        if (collision.tag == "Player")
        {
            //������� ���������� ��� ���������� Player, ������� �������� ���� ������
            Player player = collision.GetComponent<Player>();
            //������������ ������ ����
            player.points++;
            //��������� �������
            Destroy(gameObject);
        }
    }
}
