using UnityEngine;

public class Coin : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement.coinCount++; // 코인 점수 증가
            Debug.Log($"현재까지 {Movement.coinCount}개의 코인획득");
            Destroy(gameObject);
 
        }
    }




}