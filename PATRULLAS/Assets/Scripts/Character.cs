using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float velocidad = 5f;

    void Update()
    {
        Vector3 direccion = CalcularMovimineto();
        Moverse(direccion);
    }

    protected void Moverse(Vector3 direccion)
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }

    protected abstract Vector3 CalcularMovimineto();

    public virtual string ObtenerTipoMovimiento()
    {
        return "Movimiento genérico";
    }

}

