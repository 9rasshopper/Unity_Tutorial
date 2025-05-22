using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;//유니티 인스펙터 창에서 드래그앤드롭으로 프리팹을 넣어줄 수 있는 변수

    public Vector3 pos; //3차원 벡터 
    public Quaternion rot; //회전값

    void Start()
    {
        CreateAmonUs();
    }

    /// <summary>
    /// 만들어둔 어몽어스 프리팹을 생성하는 메소드
    /// </summary>
    public void CreateAmonUs()
    {
        GameObject obj = Instantiate(prefab, pos, rot);//GameObject를 생성하는 메소드
        //       생성할 데이터,생성할 위치,회전값
        obj.name = "어몽어스 캐릭터";

        Debug.Log($"캐릭터의 자식오브젝트의 수 : {obj.transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식오브젝트의 이름 : {obj.transform.GetChild(obj.transform.childCount - 1).name}");

    }
}

    
 

