using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        //ĳ���Ͱ� Ư�� ��ġ�� �ٶ󺸴� ���
        //transform.LookAt(new Vector3(0f, 10f, 0f));

        //ĳ���Ͱ� ������� ������ �̵��ϴ� ���
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //ĳ���Ͱ� ���ù��� ������ �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        //float yRotation = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float xLocal = transform.eulerAngles.x;
        //float zLocal = transform.eulerAngles.z;

        //float zLocal = transform //��������� Y���� �������� ȸ���ϴ±�� / Quaternion����� Euler���Ϸ�.eulerAngles.z
        //transform.rotation = Quaternion.Euler(xLocal, yRotation, zLocal);

        //���ù���Y���� �������� ȸ���ϴ� ���
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // ���� ��ǥ (0,0,0)�� �߽����� ȸ��
        transform.RotateAround(Vector3.zero/*Vector3(0f, 0f, 0f)*/, Vector3.up/*Vector3(0f, 1f, 0f)*/,
                                rotateSpeed * Time.deltaTime);
        
    }
}
