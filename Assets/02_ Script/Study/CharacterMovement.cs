using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D charRb;
    public SpriteRenderer[] renderers;    

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;
    private float v;

    private bool isGround; // 바닥에 닿아있는지 여부
    void Start()
    {
        charRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
        
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        Jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        isGround = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;

        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true); // Jump
    }



    /// <summary>
    /// 캐릭터가 점프하는기능
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            charRb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    /// <summary>
    /// 캐릭터 움직임과 움직임에 따라 이미지의 Flip을 조정하는 기능
    /// </summary>
    private void Move()
    {
        if (!isGround)
            return;

        if (h != 0)
        {
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);
            renderers[2].gameObject.SetActive(false);
            //물리적인 이동 
            charRb.linearVelocityX = h * moveSpeed;
            if (h < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
            else if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
        }
        else
        {
            renderers[0].gameObject.SetActive(true);
            renderers[1].gameObject.SetActive(false);
            renderers[2].gameObject.SetActive(false);

        }
    }
}
