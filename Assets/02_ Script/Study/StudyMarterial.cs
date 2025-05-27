using Unity.Mathematics;
using UnityEngine;

public class StudyMarterial : MonoBehaviour
{
    public Material mat; // Material to be applied to the GameObject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string hexcode;
    void Start()
    {
        //   this.GetComponent()<Material>() = mat; //Material을 바꾸는 방식

        //this.GetComponent<MeshRenderer>().material = mat; //Mesh Renderer에 접근해서 바꾸는 방식

        //this.GetComponent<MeshRenderer>().material.color = Color.green; //자신 머티리얼의 색상을 바꾸는 방식 종료하면 원래대로 돌아감

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; //원본 머티리얼의 색상을 바꾸는 방식 위험한 기능

        //materials 는 배열이기때문에 여러개를 넣을수 있다 접근할때는 인덱스를 사용

        //this.GetComponent<MeshRenderer>().material.color = new Color(255f/255f, 1f/255, 255f/255f, 1); // color를 직접 지정하는 방식

        ///hexcode를 사용해서 색상을 지정하는 방식
        //mat = this.GetComponent<MeshRenderer>().material;
        //Color outputColor;
        //if (ColorUtility.TryParseHtmlString(hexcode, out outputColor)) // hexcode를 색상으로 변환
        //{
        //    mat.color = outputColor; // 머티리얼의 색상을 변경
        //}

    }

}
