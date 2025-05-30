using UnityEngine;

public class DoorEvent2 : MonoBehaviour
{
    private Animator animator;

    public string openkey;
    public string closekey;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {  
            animator.SetTrigger("Close");
    }


}
