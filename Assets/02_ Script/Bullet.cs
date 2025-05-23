using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed =70f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        // this.이 생략되어있음 자신의 위치에서 앞으로

        Destroy(this.gameObject, 3f);
    }
}
