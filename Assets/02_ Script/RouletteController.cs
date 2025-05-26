using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;
    public bool isStop = false; 
    private void Update()
    {
        this.transform.Rotate(Vector3.forward * rotSpeed); // z축을 기준으로 회전 forward 는 z축 방향을 의미합니다.
        /// 마우스 오른클릭을 누를때 회전하는 기능
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
            //Space 키를 누르면 회전 속도를 0.98배로 줄입니다.
            //rotSpeed = rotSpeed * 0.98f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false; // 회전이 멈추면 isStop을 false로 변경
            }
        }

        //transform.Rotate(0f, 0f, rotSpeed); //위의 줄과 동일한 기능 / 매개변수로 들어간 값을 축으로 회전합니다.
    }

}
