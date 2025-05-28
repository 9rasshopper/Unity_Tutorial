using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    float h; 

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        //�Ʒ��� ������� �̵��ϴ°�� ���� ����ؼ� �浹�ϰԵǸ� ���� ������ �߻��Ѵ�.
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

    }

    void FixedUpdate()
    {
        //������ �̵��� FixedUpdate���� ó���ؾ� �Ѵ�.
        carRb.linearVelocityX = h * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter");

    }
    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("OnCollisionStay");

    }
    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("OnCollisionExit");

    }
}
