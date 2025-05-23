using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{
    public GameObject obj;
    public Mesh msh;
    public Material mater;

    void Start()
    {
        obj = new GameObject("ť��");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;


        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mater;

        obj.AddComponent<BoxCollider>();


    }

    
}
