using UnityEngine;

public interface IAlien
{
    string Nombre { get; }
    Sprite Imagen { get; }
    string Mensaje { get; }
}

// ==== Ejemplos de Aliens ====
public class Diamante : IAlien
{
    public string Nombre => "Diamante";
    public Sprite Imagen { get; private set; }

    public string Mensaje => "¡Transformado en Diamante!";
    public Diamante(Sprite img) { Imagen = img; }

}

public class CuatroBrazos : IAlien
{
    public string Nombre => "Cuatro Brazos";
    public Sprite Imagen { get; private set; }

    public string Mensaje => "¡Transformado en cuatro brazos!";

    public CuatroBrazos(Sprite img) { Imagen = img; }

}

public class XLR8 : IAlien
{
    public string Nombre => "XLR8";
    public Sprite Imagen { get; private set; }

    public string Mensaje => "¡Transformado en XLR8!";

    public XLR8(Sprite img) { Imagen = img; }

}
public class FuegoPantanoso : IAlien
{
    public string Nombre => "Fuego Pantanoso";
    public Sprite Imagen { get; private set; }
    public string Mensaje => "¡Transformado en Fuego pantanoso!";

    public FuegoPantanoso(Sprite img) { Imagen = img; }

    
}