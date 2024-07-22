using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables de movimiento
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private float moveInput;

    // Referencias al Rigidbody2D y al ground check
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;
    private Animator animator;
    private bool facingRight = true; // Variable para controlar la direcci�n del sprite

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        // Movimiento horizontal
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Voltear el sprite seg�n la direcci�n
        if (moveInput > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight)
        {
            Flip();
        }

        // Actualizar animaci�n de correr
        if (Mathf.Abs(moveInput) > 0)
        {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }

        // Verificar si el jugador est� en el suelo
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        // Saltar
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Interacci�n
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Flip()
    {
        // Voltear el sprite
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void Interact()
    {
        // Implementa aqu� la l�gica de interacci�n
        Debug.Log("Interacci�n realizada");
    }
}
