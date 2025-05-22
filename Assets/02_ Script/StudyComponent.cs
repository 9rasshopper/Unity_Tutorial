using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    
    //public string ChangeName = "태그로 찾기";

    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        // 오브젝트를 이름으로 찾는 기능 
        // 이름이 같으면 가장 나중에 생성된 것을 찾음 
        // 모든 이름을 하나씩 검색해 보기 때문에 비효율적임
        
        obj = GameObject.FindGameObjectWithTag("태그");

        Debug.Log($"위치 : {obj.transform.position}");

        //Debug.Log($"<color=#ff0000>이름 : {obj.name}</color>");
        //Debug.Log($"<color=#00ff00>태그 : {obj.tag}</color>");
        //Debug.Log($"<color=#0000ff>위치 : {obj.transform.position}</color>");
        //Debug.Log($"<color=#ffff00>회전 : {obj.transform.rotation}</color>");
        //Debug.Log($"<color=#00ffff>크기 : {obj.transform.localScale}</color>");

        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshFilter 컴포넌트에 접근해서 mesh를 Log으로 출력하는 기능

        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        // MeshRenderer 컴포넌트에 접근해서 material을 Log으로 출력하는 기능

        obj.GetComponent<MeshRenderer>().enabled = false;
        // MeshRenderer 컴포넌트에 접근해서 활성상태를 false로 바꾸는 기능
        obj.SetActive(false);
    }

}
