using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj;
    
    public string ChangeName = "카메라";

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = ChangeName;
        //오브젝트의 이름을 바꾸는 기능
       
    }

}
