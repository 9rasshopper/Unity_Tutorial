using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{
    public float offsetSpeed = 10f; // Speed of the offset
    private MeshRenderer meshrenderer; // Reference to the MeshRenderer component

    void Start()
    {
       meshrenderer = GetComponent<MeshRenderer>();

    }

    void Update()
    {
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;
        
        meshrenderer.material.SetTextureOffset("_MainTex",meshrenderer.material.mainTextureOffset + offset);
        
    }
}