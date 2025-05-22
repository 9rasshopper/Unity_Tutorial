using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //Input System (Old Legacy)
        //입력값에 대한 약속된 시스템
        //이동wasd, 화살표키
        //점프 space
        //총쏘기 마우스왼쪽

        float h  = Input.GetAxis("Horizontal"); //a,d,좌우키
        float v  = Input.GetAxis("Vertical"); //w,s,상하키
        float j = Input.GetAxis("Jump"); //space

        Vector3 dir = new Vector3(h, j, v);
        Debug.Log($"현재입력 : {dir}");

        transform.position += dir * speed * Time.deltaTime; //이동하는 방향에 속도와 시간을 곱해줌


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

