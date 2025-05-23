using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;//����Ƽ �ν����� â���� �巡�׾ص������ �������� �־��� �� �ִ� ����

    public Vector3 pos; //3���� ���� 
    public Quaternion rot; //ȸ����

    void Awake()//����Ƽ���� ���� ���� ����Ǵ� �޼ҵ� 
    {
        CreateAmonUs();
    }

    /// <summary>
    /// ������ ���� �������� �����ϴ� �޼ҵ�
    /// </summary>
    public void CreateAmonUs()
    {
        GameObject obj = Instantiate(prefab, pos, rot);//GameObject�� �����ϴ� �޼ҵ�
        //       ������ ������,������ ��ġ,ȸ����
        obj.name = "���� ĳ����";

        Debug.Log($"ĳ������ �ڽĿ�����Ʈ�� �� : {obj.transform.childCount}");
        Debug.Log($"ĳ������ ù��° �ڽĿ�����Ʈ�� �̸� : {obj.transform.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽĿ�����Ʈ�� �̸� : {obj.transform.GetChild(obj.transform.childCount - 1).name}");

    }
}

    
 

