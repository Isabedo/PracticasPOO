using UnityEngine;

public class Circular: Character
{
    [SerializeField] private Transform centro;
    protected override Vector3 CalcularMovimineto()
    {
        if (centro == null) { return Vector3.zero; }
        Vector3 direccion = (transform.position - centro.position).normalized;
        Vector3 tangente = new Vector3(-direccion.y, direccion.x, 0);
        return tangente;
    }
}
