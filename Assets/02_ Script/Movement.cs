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

        ///�ε巯�
        //float h  = Input.GetAxis("Horizontal"); //a,d,�¿�Ű
        //float v  = Input.GetAxis("Vertical"); //w,s,����Ű
        //float j = Input.GetAxis("Jump"); //space


        ///�� �������°�
        float h = Input.GetAxisRaw("Horizontal"); //a,d,�¿�Ű
        float v = Input.GetAxisRaw("Vertical"); //w,s,����Ű


        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized; //����ȭ�� ����, ���⸸ ����� ũ�⸦ 0 ~ 1�� �������

        Debug.Log($"�����Է� : {normalDir}");

        transform.position += dir.normalized * speed * Time.deltaTime; //�̵��ϴ� ���⿡ �ӵ��� �ð��� ������
        transform.LookAt(transform.position + dir.normalized); //�̵��ϴ� ������ �ٶ󺸰� ����

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

