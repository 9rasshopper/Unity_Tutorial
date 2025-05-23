using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    // Ÿ���� �ٶ󺸰� �� ������Ʈ������ ������ ��ġ�� Ȯ���ؾ� �ϱ⶧����
    // GameObject.Taransform�� �Ź� ����ϴ°ͺ��� ó���� Transform�� ������ ����ϸ� ����
    public Transform turretHead;

    public GameObject bulletPrefab;//�Ѿ� ������
    public Transform firePos;//�߻���ġ

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        //Ÿ���� �����ϰ� ��ġ���� ������
    }

    
    void Update()
    {
        turretHead.LookAt(targetTf); //Ÿ���� ��ġ�� �ٶ󺸰� ��

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            // �Ѿ� ����
            //           ���� ��� ,        ���� ��ġ,           ȸ������
        }

    }
}
