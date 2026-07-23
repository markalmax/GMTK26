using UnityEngine;

public class Player : Actors
{
   
    void Update()
    {
        float XInput = Input.GetAxis("Horizontal");
        float YInput = Input.GetAxis("Vertical");
        Move(new Vector2(XInput, YInput));
    }
}
