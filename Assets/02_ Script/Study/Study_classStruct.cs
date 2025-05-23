using UnityEngine;

public class Study_Class
{
   public int num;

    public Study_Class(int num)
    {
        this.num = num;
    }
}   

public struct Study_Struct
{
    public int num;

    public Study_Struct(int num)
    {
        this.num = num;
    }
}

public class Study_classStruct : MonoBehaviour
{   
    void Start()
    {
        Debug.Log("클래스 --------------------------");
        Study_Class class1 = new Study_Class(10);
        Study_Class class2 = class1;
        Debug.Log($"Class 1 : {class1.num} / Class 2 : {class2.num}");

        class1.num = 100;
        Debug.Log($"Class 1 : {class1.num} / Class 2 : {class2.num}");

        Debug.Log("구조체 --------------------------");
        Study_Struct struct1 = new Study_Struct(10);
        Study_Struct struct2 = struct1;
        Debug.Log($"Struct 1 : {struct1.num} / Struct 2 : {struct2.num}");

        struct1.num = 100;
        Debug.Log($"Struct 1 : {struct1.num} / Struct 2 : {struct2.num}");

    }

}
