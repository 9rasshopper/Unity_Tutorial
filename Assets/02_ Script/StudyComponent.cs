using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj;
    
    public string ChangeName = "ī�޶�";

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = ChangeName;
        //������Ʈ�� �̸��� �ٲٴ� ���
       
    }

}
