using Unity.Mathematics;
using UnityEngine;

public class StudyMarterial : MonoBehaviour
{
    public Material mat; // Material to be applied to the GameObject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string hexcode;
    void Start()
    {
        //   this.GetComponent()<Material>() = mat; //Material�� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().material = mat; //Mesh Renderer�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().material.color = Color.green; //�ڽ� ��Ƽ������ ������ �ٲٴ� ��� �����ϸ� ������� ���ư�

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; //���� ��Ƽ������ ������ �ٲٴ� ��� ������ ���

        //materials �� �迭�̱⶧���� �������� ������ �ִ� �����Ҷ��� �ε����� ���

        //this.GetComponent<MeshRenderer>().material.color = new Color(255f/255f, 1f/255, 255f/255f, 1); // color�� ���� �����ϴ� ���

        ///hexcode�� ����ؼ� ������ �����ϴ� ���
        //mat = this.GetComponent<MeshRenderer>().material;
        //Color outputColor;
        //if (ColorUtility.TryParseHtmlString(hexcode, out outputColor)) // hexcode�� �������� ��ȯ
        //{
        //    mat.color = outputColor; // ��Ƽ������ ������ ����
        //}

    }

}
