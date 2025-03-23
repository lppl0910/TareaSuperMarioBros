using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class CerrarCreditos : MonoBehaviour
{
    public Button botonRegreso;

    void Start()
    {
        if (botonRegreso != null)
        {
            botonRegreso.gameObject.SetActive(false);
            botonRegreso.onClick.AddListener(RegresarAlMenu);
        }
    }

    private void RegresarAlMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void ActivarBoton()
    {
        if (botonRegreso != null)
        {
            botonRegreso.gameObject.SetActive(true);
        }
    }

    public void DesactivarBoton()
    {
        if (botonRegreso != null)
        {
            botonRegreso.gameObject.SetActive(false);
        }
    }
}
