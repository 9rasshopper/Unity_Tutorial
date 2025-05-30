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
        if (other.CompareTag("Player")) // 플레이어가 트리거에 들어오면 문을 열도록 설정
        {
            animator.SetTrigger("Open"); // 트리거가 활성화되면 문을 열도록 설정
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
            animator.SetTrigger("Close"); // 트리거가 활성화되면 문을 열도록 설정
    }

}
