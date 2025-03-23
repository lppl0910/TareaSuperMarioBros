using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

// Script para manejar los botones del menú principal
public class MenuController : MonoBehaviour
{
    private UIDocument menu;
    private VisualElement contenedorBotones;
    private Label textoAyuda;
    private Button salidaAyuda;
    private Button botonJuego;
    private Button botonAyuda;
    private Button botonCreditos;

    public CerrarCreditos cerrarCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        contenedorBotones = root.Q<VisualElement>("ContenedorBotones");
        textoAyuda = root.Q<Label>("textoAyuda");
        salidaAyuda = root.Q<Button>("SalidaAyuda");
        botonJuego = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");

        salidaAyuda.RegisterCallback<ClickEvent>(SalirDeAyuda);
        botonJuego.RegisterCallback<ClickEvent>(IniciarJuego);
        botonAyuda.RegisterCallback<ClickEvent>(MostrarAyuda);
        botonCreditos.RegisterCallback<ClickEvent>(MostrarCreditos);
    }

    private void IniciarJuego(ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void MostrarAyuda(ClickEvent evt)
    {
        contenedorBotones.Clear();
        textoAyuda.style.display = DisplayStyle.Flex;
        salidaAyuda.style.display = DisplayStyle.Flex;
        contenedorBotones.Add(textoAyuda);
        contenedorBotones.Add(salidaAyuda);

        cerrarCreditos.ActivarBoton();
    }

    private void SalirDeAyuda(ClickEvent evt)
    {
        contenedorBotones.Clear();
        contenedorBotones.Add(botonJuego);
        contenedorBotones.Add(botonAyuda);
        contenedorBotones.Add(botonCreditos);
        
        cerrarCreditos.DesactivarBoton();
    }

    private void MostrarCreditos(ClickEvent evt)
    {
        SceneManager.LoadScene("EscenaCreditos");
    }
}
