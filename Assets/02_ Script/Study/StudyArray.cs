using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    //public int[] arrayNum = new int[5] { 1, 2, 3, 4, 5 }; 

    //public List<int> listNum = new List<int>(); 
    // List 를 사용할 경우 using System.Collections.Generic;을 추가해야 한다.

    //int number1 = 1; //int 앞에 아무것도 적지않으면 private와 동일하므로 유니티 인스펙터에 보이지 않음
    //private int number2 = 2; //private는 인스펙터에 보이지 않음

    //public int number3 = 3; //public은 유니티 인스펙터에만 보임
    //[SerializeField] private int number4 = 4;   //private는 인스펙터에 보이지 않지만 [SerializeField]를 붙이면 인스펙터에서만 보임

    //[SerializeField]  //[SerializeField] = 직렬화된 필드, 인스펙터에서 보이게 해주는 속성 / 위쪽에 붙여도 됨
    //int number5 = 5; // private와 동일하므로 유니티 인스펙터에 보이지 않지만 [SerializeField]를 붙이면 인스펙터에서만 보임      



    void Start()
    {
        //Debug.Log($"Array의 첫번째값 : {arrayNum[0]}");
        //Debug.Log($"Array의 두번째값 : {arrayNum[1]}");
        //Debug.Log($"Array의 세번째값 : {arrayNum[2]}");
        //Debug.Log($"Array의 네번째값 : {arrayNum[3]}");
        //Debug.Log($"Array의 여섯번째값 : {arrayNum[5]}");
        //Debug.Log($"현재 Array에 있는 데이터 수는 : {arrayNum.Lenth}");

        //listNum.Add(1);
        //listNum.Add(2);
        //listNum.Add(3);
        //listNum.Add(4);
        //listNum.Add(5);
        //listNum[0]; : listNum의 첫번째 값
        //Debug.Log($"Array의 첫번째값 : {listNum[0]}");
        //Debug.Log($"Array의 두번째값 : {listNum[1]}");
        //Debug.Log($"Array의 세번째값 : {listNum[2]}");
        //Debug.Log($"Array의 네번째값 : {listNum[3]}");
        //Debug.Log($"현재 List에 있는 데이터 수는 : {listNum.Count}");
        //Debug.Log($"List의 마지막 데이터 : {listNum[listNum.Count - 1]}");

    }

}
