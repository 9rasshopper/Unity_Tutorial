using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    void Awake()
    {
       Debug.Log("Awake");
       
    }
    void Start()
    {
        Debug.Log("Start");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
