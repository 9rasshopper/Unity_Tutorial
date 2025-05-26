using Unity.VisualScripting;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{   
    public float destroyTime = 3f; // 파괴될 시간
    void Start() //시작될때 한번 실행
    {
        Destroy(this.gameObject, destroyTime);

        
    }

    private void OnDestroy() //파괴되거나 프로그램 종료시 1번실행
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다");
    }
}
