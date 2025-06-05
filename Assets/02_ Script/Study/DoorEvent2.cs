using UnityEngine;

public class DoorEvent2 : MonoBehaviour
{
    private Animator animator;
    public GameObject doorLock;

    public string openkey;
    public string closekey;
    void Start()
    {
        animator = GetComponent<Animator>();

    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
            doorLock.SetActive(true);
            //animator.SetTrigger("Open");
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        doorLock.SetActive(false);
       
        //animator.SetTrigger("Close");
            
      
        
    }
    


}
