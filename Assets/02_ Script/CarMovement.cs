using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    float h; 

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        //아래의 방식으로 이동하는경우 벽에 계속해서 충돌하게되면 떨림 현상이 발생한다.
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

    }

    void FixedUpdate()
    {
        //물리적 이동은 FixedUpdate에서 처리해야 한다.
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
