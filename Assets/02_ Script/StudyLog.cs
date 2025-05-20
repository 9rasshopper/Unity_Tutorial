using System;
using UnityEngine;


public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("일반 로그");//일반적인 로그
        Debug.LogWarning("경고 로그"); // 경고 로그
        Debug.LogError("에러 로그"); // 에러 로그

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
