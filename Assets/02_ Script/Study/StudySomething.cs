using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;
    void Start()
    {
        //bool isMax = currentLevel >= maxLevel;
        //if (isMax)
        //{
        //    Debug.Log("���緹���� �����Դϴ�");
        //}
        //else
        //{
        //    Debug.Log("���緹���� ������ �ƴմϴ�");
        //}

        ///���� ������ ���
        string msg = currentLevel >= maxLevel ? "���� �����Դϴ�." : "���� ������ �ƴմϴ�.";

        Debug.Log(msg);


    }
 
}
