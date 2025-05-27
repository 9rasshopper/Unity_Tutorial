using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f; // 이동 속도
    public float height = -5f;
    private Vector3 returnPos;


    void Start()
    {
         returnPos = new Vector3(42f, height, 0f);
    }
    void Update()
    {
        //배경 왼쪽으로 이동 Time.deltaTime을 사용하면 컴퓨터 성능에 따라 달라지는 프레임 레이트 떄문에 속도가 달라져 배경이나 발판이 끊기는 경우가 발생
        //Time.fixedDeltaTime를 사용하여 일정한 속도로 이동
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);
        if (transform.position.x <= -42f)
        {
            //배경을 재사용하기위해 오른쪽 x = 42로 초기화
            transform.position = returnPos;
        }
    }
}
