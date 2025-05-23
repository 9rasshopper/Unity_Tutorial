using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    
    //public string ChangeName = "�±׷� ã��";

    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        // ������Ʈ�� �̸����� ã�� ��� 
        // �̸��� ������ ���� ���߿� ������ ���� ã�� 
        // ��� �̸��� �ϳ��� �˻��� ���� ������ ��ȿ������
        
        obj = GameObject.FindGameObjectWithTag("�±�");

        Debug.Log($"��ġ : {obj.transform.position}");

        //Debug.Log($"<color=#ff0000>�̸� : {obj.name}</color>");
        //Debug.Log($"<color=#00ff00>�±� : {obj.tag}</color>");
        //Debug.Log($"<color=#0000ff>��ġ : {obj.transform.position}</color>");
        //Debug.Log($"<color=#ffff00>ȸ�� : {obj.transform.rotation}</color>");
        //Debug.Log($"<color=#00ffff>ũ�� : {obj.transform.localScale}</color>");

        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshFilter ������Ʈ�� �����ؼ� mesh�� Log���� ����ϴ� ���

        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");
        // MeshRenderer ������Ʈ�� �����ؼ� material�� Log���� ����ϴ� ���

        obj.GetComponent<MeshRenderer>().enabled = false;
        // MeshRenderer ������Ʈ�� �����ؼ� Ȱ�����¸� false�� �ٲٴ� ���
        obj.SetActive(false);
    }

}
