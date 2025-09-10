using UnityEngine;

public class Player: Character
{
    protected override Vector3 CalcularMovimineto()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        return new Vector3(x, y,0);
    }
}
