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
        //    Debug.Log("현재레벨은 만렙입니다");
        //}
        //else
        //{
        //    Debug.Log("현재레벨은 만렙이 아닙니다");
        //}

        ///삼항 연산자 사용
        string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다.";

        Debug.Log(msg);


    }
 
}
