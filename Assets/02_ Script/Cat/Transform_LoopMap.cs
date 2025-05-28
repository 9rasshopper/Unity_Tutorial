using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f; // �̵� �ӵ�
    public float height = -5f;
    private Vector3 returnPos;


    void Start()
    {
         returnPos = new Vector3(42f, height, 0f);
    }
    void Update()
    {
        //��� �������� �̵� Time.deltaTime�� ����ϸ� ��ǻ�� ���ɿ� ���� �޶����� ������ ����Ʈ ������ �ӵ��� �޶��� ����̳� ������ ����� ��찡 �߻�
        //Time.fixedDeltaTime�� ����Ͽ� ������ �ӵ��� �̵�
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);
        if (transform.position.x <= -42f)
        {
            //����� �����ϱ����� ������ x = 42�� �ʱ�ȭ
            transform.position = returnPos;
        }
    }
}
