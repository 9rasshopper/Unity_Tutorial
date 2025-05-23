using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    // 타겟을 바라보게 할 오브젝트이지만 어차피 위치를 확인해야 하기때문에
    // GameObject.Taransform을 매번 사용하는것보다 처음에 Transform을 가져와 사용하면 좋다
    public Transform turretHead;

    public GameObject bulletPrefab;//총알 프리펩
    public Transform firePos;//발사위치

    public float timer;
    public float cooldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        //타겟을 지정하고 위치값을 가져옴
    }

    
    void Update()
    {
        turretHead.LookAt(targetTf); //타겟의 위치를 바라보게 함

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            // 총알 생성
            //           생성 대상 ,        생성 위치,           회전상태
        }

    }
}
