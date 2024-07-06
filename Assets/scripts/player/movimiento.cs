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

        // Actualizar animaci�n de correr
        if (moveInput != 0)
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

    private void Interact()
    {
        // Implementa aqu� la l�gica de interacci�n
        Debug.Log("Interacci�n realizada");
    }
}
