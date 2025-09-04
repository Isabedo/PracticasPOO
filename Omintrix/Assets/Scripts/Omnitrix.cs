using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Omnitrix : MonoBehaviour
{
    public Image imagenCanvas; 
    public Sprite diamanteSprite;
    public Sprite cuatroBrazosSprite;
    public Sprite xlr8Sprite;
    public Sprite fuegoPantanosoSprite;
    public TextMeshProUGUI AlienTexto;


    private List<IAlien> aliens = new List<IAlien>();
    private int indiceActual = 0;

    private void Start()
    {
        aliens.Add(new Diamante(diamanteSprite));
        aliens.Add(new CuatroBrazos(cuatroBrazosSprite));
        aliens.Add(new XLR8(xlr8Sprite));
        aliens.Add(new FuegoPantanoso(fuegoPantanosoSprite));

        ActualizarCanvas();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            indiceActual++;
            if (indiceActual >= aliens.Count)
                indiceActual = 0;

            ActualizarCanvas();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            indiceActual--;
            if (indiceActual < 0)
                indiceActual = aliens.Count - 1;

            ActualizarCanvas();
        }

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            AlienTexto.text = aliens[indiceActual].Mensaje;
        }
    }

    private void ActualizarCanvas()
    {
        var alienActual = aliens[indiceActual];
        imagenCanvas.sprite = alienActual.Imagen;
        AlienTexto.text = alienActual.Nombre;
        
    }
}