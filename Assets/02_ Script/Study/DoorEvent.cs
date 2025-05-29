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
        animator.SetTrigger("Open"); // 트리거가 활성화되면 문을 열도록 설정
    }

}
