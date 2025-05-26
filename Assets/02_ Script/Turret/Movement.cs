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

        ///부드러운값
        //float h  = Input.GetAxis("Horizontal"); //a,d,좌우키
        //float v  = Input.GetAxis("Vertical"); //w,s,상하키
        //float j = Input.GetAxis("Jump"); //space


        ///딱 떨어지는값
        float h = Input.GetAxisRaw("Horizontal"); //a,d,좌우키
        float v = Input.GetAxisRaw("Vertical"); //w,s,상하키


        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized; //정규화된 벡터, 방향만 남기고 크기를 0 ~ 1로 만들어줌

        Debug.Log($"현재입력 : {normalDir}");

        transform.position += dir.normalized * speed * Time.deltaTime; //이동하는 방향에 속도와 시간을 곱해줌
        transform.LookAt(transform.position + dir.normalized); //이동하는 방향을 바라보게 해줌

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

