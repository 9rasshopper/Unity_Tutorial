using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed =70f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        // this.�� �����Ǿ����� �ڽ��� ��ġ���� ������

        Destroy(this.gameObject, 3f);
    }
}
