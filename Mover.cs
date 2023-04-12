using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //���������� ��� ������ �������� �������
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //��������� ������ ����� 5������ ����� ������ ����
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //������ �������� � ����������� ���� � ���������� ���������, �������� �������� ����
        transform.position = (Vector2)transform.position + Vector2.down * (speed+GameController.gameSpeed) * Time.deltaTime;
    }
}
