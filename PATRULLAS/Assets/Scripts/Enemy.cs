using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Transform[] puntosPatrulla;
    private int puntoActual = 0;
    protected override Vector3 CalcularMovimineto()
    {
       if (puntosPatrulla.Length == 0) { return Vector3.zero; }
        Vector3 objetivo = puntosPatrulla[puntoActual].position;
        Vector3 direccion = (objetivo - transform.position).normalized;

        if (Vector3.Distance(transform.position, objetivo) < 0.1f) {
            puntoActual = (puntoActual + 1) % puntosPatrulla.Length;
        }
        return direccion;
    }
}
