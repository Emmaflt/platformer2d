using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f; //vitesse
    public float jumpForce = 5f; //force saut

    private bool isGrounded; //est ce que je suis au sol ?
    public Transform groundCheck;
    public float checkRadius = 0.2f; // taille de la verif
    public LayerMask groundLayer; // Quel sol je touche

    // Références pour le Rigidbody2D
    private Rigidbody2D rb;

    // Ref pour l'animator
    public Animator animator;
    private Vector2 movement; 

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Mvmt horizontal
        float moveInput = Input.GetAxis("Horizontal"); // -1 (gauche) / 1 (droite)
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        animator.SetFloat("Speed", Mathf.Abs(moveInput));


        // Saut
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    // Pour voir si le check sol fonctionne, a enlever plus tard
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
    }
}

