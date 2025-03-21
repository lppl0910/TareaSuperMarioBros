using UnityEngine;
// Checa si el personaje se encuentra o no en el suelo
public class EstadoPersonaje : MonoBehaviour
{
    public static bool enPiso { get; private set; }
    void Start()
    {
        enPiso = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}
