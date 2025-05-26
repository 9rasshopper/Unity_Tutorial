using UnityEngine;
using DevA;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA programmerA;
    // 유니티 에서는  = new ProgrammerA();생략

    private void Start()
    {
        //programmerA.Num = 10; 
        // int Num;은 private이 생략되어있는 변수라 접근 불가

        programmerA.publicNum = 20;

        // programmerA.serializedNum = 30;
        //programmerA.serializedNum2 = 40;
        // serializedNum은 private이 생략되어있는 변수라 접근 불가


    }
}
