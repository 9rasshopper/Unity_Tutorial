using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //Input System (Old Legacy)
        //�Է°��� ���� ��ӵ� �ý���
        //�̵�wasd, ȭ��ǥŰ
        //���� space
        //�ѽ�� ���콺����

        float h  = Input.GetAxis("Horizontal"); //a,d,�¿�Ű
        float v  = Input.GetAxis("Vertical"); //w,s,����Ű
        float j = Input.GetAxis("Jump"); //space

        Vector3 dir = new Vector3(h, j, v);
        Debug.Log($"�����Է� : {dir}");

        transform.position += dir * speed * Time.deltaTime; //�̵��ϴ� ���⿡ �ӵ��� �ð��� ������


        //if (Input.GetKey(KeyCode.W))
        //{
        //    this.transform.position += Vector3.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    this.transform.position += Vector3.back * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    this.transform.position += Vector3.left * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    this.transform.position += Vector3.right * speed * Time.deltaTime;
        //}
    }
}

