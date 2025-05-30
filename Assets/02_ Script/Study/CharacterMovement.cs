using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D charRb;
    public SpriteRenderer[] renderers;    

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;
    private float v;

    private bool isGround; // �ٴڿ� ����ִ��� ����
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
    /// ĳ���Ͱ� �����ϴ±��
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            charRb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    /// <summary>
    /// ĳ���� �����Ӱ� �����ӿ� ���� �̹����� Flip�� �����ϴ� ���
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
            //�������� �̵� 
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
