using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PinBall : MonoBehaviour
{
    public Pinball_Manager pinballManager;
    private void OnCollisionEnter2D(Collision2D other) //�浹�������
    {
        switch (other.gameObject.tag)
        {
            case "Score10":
                Debug.Log("Score10 ȹ��");
                pinballManager.totalScore += 10; // ���� �߰�
                break;
            case "Score50":
                Debug.Log("Score50 ȹ��");
                pinballManager.totalScore += 50; // ���� �߰�
                break;
            case "Score100":
                Debug.Log("Score100 ȹ��");
                pinballManager.totalScore += 100; // ���� �߰�
                break;
        }

        //if (other.gameObject.CompareTag("Score10"))
        //{
        //    Debug.Log("Score10 ȹ��");
        //    pinballManager.totalScore += 10; // ���� �߰�
        //}

        //else if (other.gameObject.CompareTag("Score50"))
        //{
        //    Debug.Log("Score50 ȹ��");
        //    pinballManager.totalScore += 50; // ���� �߰�
        //}

        //else if (other.gameObject.CompareTag("Score100"))
        //{
        //    Debug.Log("Score100 ȹ��");
        //    pinballManager.totalScore += 100; // ���� �߰�
        //}
    }

    private void OnTriggerEnter2D(Collider2D other) //Ʈ���� �����������
    {
        if (other.gameObject.CompareTag("GameOver"))
            Debug.Log($"���� ���� ���������� : {pinballManager.totalScore} �Դϴ�");

    }

}
