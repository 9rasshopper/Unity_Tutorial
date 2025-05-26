using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        //캐릭터가 특정 위치를 바라보는 기능
        //transform.LookAt(new Vector3(0f, 10f, 0f));

        //캐릭터가 월드방향 앞으로 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //캐릭터가 로컬방향 앞으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        //float yRotation = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float xLocal = transform.eulerAngles.x;
        //float zLocal = transform.eulerAngles.z;

        //float zLocal = transform //월드방향의 Y축을 기준으로 회전하는기능 / Quaternion사원수 Euler오일러.eulerAngles.z
        //transform.rotation = Quaternion.Euler(xLocal, yRotation, zLocal);

        //로컬방향Y축을 기준으로 회전하는 기능
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 월드 좌표 (0,0,0)을 중심으로 회전
        transform.RotateAround(Vector3.zero/*Vector3(0f, 0f, 0f)*/, Vector3.up/*Vector3(0f, 1f, 0f)*/,
                                rotateSpeed * Time.deltaTime);
        
    }
}
