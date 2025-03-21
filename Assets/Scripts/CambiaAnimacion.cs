using UnityEngine;

// Para cambiar entre animaciones del personaje

public class CambiaAnimacion : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public SpriteRenderer flipX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Velocidad", Mathf.Abs(rb.linearVelocityX));
        // Voltear al personaje según la dirección en la cual se mueva usando el sprite renderer
        if (rb.linearVelocityX > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (rb.linearVelocityX < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        animator.SetBool("enPiso", EstadoPersonaje.enPiso);
    }
}
