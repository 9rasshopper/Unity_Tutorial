using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;
    public bool isStop = false; 
    private void Update()
    {
        this.transform.Rotate(Vector3.forward * rotSpeed); // z���� �������� ȸ�� forward �� z�� ������ �ǹ��մϴ�.
        /// ���콺 ����Ŭ���� ������ ȸ���ϴ� ���
        if(Input.GetMouseButtonDown(0))
        {
                rotSpeed = 5f; 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.99f;
            //Space Ű�� ������ ȸ�� �ӵ��� 0.98��� ���Դϴ�.
            //rotSpeed = rotSpeed * 0.98f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false; // ȸ���� ���߸� isStop�� false�� ����
            }
        }

        //transform.Rotate(0f, 0f, rotSpeed); //���� �ٰ� ������ ��� / �Ű������� �� ���� ������ ȸ���մϴ�.
    }

}
