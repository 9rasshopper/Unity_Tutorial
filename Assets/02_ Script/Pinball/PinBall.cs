using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PinBall : MonoBehaviour
{
    public Pinball_Manager pinballManager;
    private void OnCollisionEnter2D(Collision2D other) //충돌했을경우
    {
        switch (other.gameObject.tag)
        {
            case "Score10":
                Debug.Log("Score10 획득");
                pinballManager.totalScore += 10; // 점수 추가
                break;
            case "Score50":
                Debug.Log("Score50 획득");
                pinballManager.totalScore += 50; // 점수 추가
                break;
            case "Score100":
                Debug.Log("Score100 획득");
                pinballManager.totalScore += 100; // 점수 추가
                break;
        }

        //if (other.gameObject.CompareTag("Score10"))
        //{
        //    Debug.Log("Score10 획득");
        //    pinballManager.totalScore += 10; // 점수 추가
        //}

        //else if (other.gameObject.CompareTag("Score50"))
        //{
        //    Debug.Log("Score50 획득");
        //    pinballManager.totalScore += 50; // 점수 추가
        //}

        //else if (other.gameObject.CompareTag("Score100"))
        //{
        //    Debug.Log("Score100 획득");
        //    pinballManager.totalScore += 100; // 점수 추가
        //}
    }

    private void OnTriggerEnter2D(Collider2D other) //트리거 감지했을경우
    {
        if (other.gameObject.CompareTag("GameOver"))
            Debug.Log($"게임 종료 최종점수는 : {pinballManager.totalScore} 입니다");

    }

}
