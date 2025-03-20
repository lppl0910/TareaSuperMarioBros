using UnityEngine;

/**
    Establece el movimiento y salto del personaje
    Autor: Luis David Pozos Tamez
 */
public class MuevePersonaje : MonoBehaviour
{
    // Velocidades

    [SerializeField] // Permite al editor de Unity acceder a la variable
    private float velocidadX;

    [SerializeField]
    private float jumpForce;

    public static bool enPiso { get; private set; } 

    // Movimiento del personaje
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enPiso = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Movimiento horizontal
        float movimientoX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movimientoX * velocidadX, rb.linearVelocityY);

        // Salto
        if (Input.GetButtonDown("Jump") && enPiso)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // Detecta si el personaje está en el suelo
    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }

}
