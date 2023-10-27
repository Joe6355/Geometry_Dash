using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Player : _Sounds
{
    public Rigidbody2D rb;
    public int jumpForce;
    public int speed;
    public bool IsGrounded;
    public Transform sprite;

    public float smoothRotationSpeed = 5f;

    private bool top;// отвечает за переворот в методе Rotate

    private bool alterJump = false;
    private bool upJump = false;
    public int alterJumpForce;

    private bool onFly = false;

    public float flyForce;//с какой силой мы летаем

    public float cast;// отвечает за подкидывание обьекта


    public GameObject Samolet;//samolet

    public GameObject FinishLevel;//фигнюшка дл€ финала уровн€


    private void Start()
    {
        Time.timeScale = 1;//страховка от неожиданных последствий
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Speed();

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && IsGrounded && upJump == false)
        {
            Jump();

            if (alterJump == true)
            {
                rb.gravityScale *= -1;
            }
        }
        else if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && IsGrounded && upJump == true)
        {
            UpJump();
        }
        else if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && onFly == true)
        {
            Fly();
        }
        else if (!IsGrounded)
        {
            SmoothRotation();
        }

        // ¬ыравнивание спрайта после прыжка
        if (IsGrounded)
        {
            AlignSprite();
        }
    }

    private void AlignSprite()
    {
        float currentRotation = sprite.rotation.eulerAngles.z;
        float roundedRotation = Mathf.Round(currentRotation / 90) * 90;

        // ѕримен€ем выравнивание
        sprite.rotation = Quaternion.Euler(0, 0, roundedRotation);
    }

    private void SmoothRotation()
    {
        if (onFly)
        {
            AlignSprite();
            return;
        }

        float targetRotation = sprite.rotation.eulerAngles.z - 90f; // ÷елевой угол вращени€, например, на 90 градусов

        // ѕлавное вращение к целевому углу
        sprite.rotation = Quaternion.Slerp(sprite.rotation, Quaternion.Euler(0, 0, targetRotation), Time.deltaTime * smoothRotationSpeed);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        IsGrounded = false;
    }

    private void UpJump()
    {
        rb.velocity = new Vector2(-rb.velocity.x, -alterJumpForce);
        IsGrounded = false;
    }

    private void Fly()
    {
        rb.velocity = new Vector2(rb.velocity.x, flyForce);
    }

    private void Speed()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Grounded"))
        {
            IsGrounded = true;
        }

        if (collision.collider.CompareTag("PortalGravity1"))
        {
            rb.gravityScale *= -1;
            Rotate();
            alterJump = true;
            Destroy(collision.gameObject);

        }
        if (collision.collider.CompareTag("PortalGravity2"))
        {
            rb.gravityScale *= -1;
            Rotate();
            alterJump = false;
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("PortalGravity3"))
        {
            rb.gravityScale *= -1;
            Rotate();
            upJump = true;
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("PortalGravity4"))
        {
            rb.gravityScale *= -1;
            Rotate();
            upJump = false;
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("PortalFly1"))
        {
            onFly = true;
            Samolet.SetActive(true);
            sprite.rotation = Quaternion.Euler(0, 0,0);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("PortalFly2"))
        {
            onFly = false;
            Samolet.SetActive(false);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("Orb1"))
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)))
            {
                Jump();
            }
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("Jump1"))
        {
            rb.velocity = new Vector2(rb.velocity.x, cast);
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("Finish"))//отвечает за концовку уровн€
        {
            FinishLevel.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
    private void Rotate()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }
}