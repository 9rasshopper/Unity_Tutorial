using Unity.VisualScripting;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{   
    public float destroyTime = 3f; // �ı��� �ð�
    void Start() //���۵ɶ� �ѹ� ����
    {
        Destroy(this.gameObject, destroyTime);

        
    }

    private void OnDestroy() //�ı��ǰų� ���α׷� ����� 1������
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�");
    }
}
