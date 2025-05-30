using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾ Ʈ���ſ� ������ ���� ������ ����
        {
            animator.SetTrigger("Open"); // Ʈ���Ű� Ȱ��ȭ�Ǹ� ���� ������ ����
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
            animator.SetTrigger("Close"); // Ʈ���Ű� Ȱ��ȭ�Ǹ� ���� ������ ����
    }

}
