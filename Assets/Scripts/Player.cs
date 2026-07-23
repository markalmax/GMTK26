using UnityEngine;

public class Player : Actors
{
   
    void Update()
    {
        float XInput = Input.GetAxis("Horizontal");
        float YInput = Input.GetAxis("Vertical");
        Move(new Vector2(XInput, YInput));
        Vector2 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = (vector - (Vector2)transform.position).normalized;
        vector= new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 vector2 = Camera.main.ScreenToWorldPoint(vector);
        vector2 -= base.transform.position;
        float num = Mathf.Atan2(vector2.y, vector2.x) * 57.29578f - 90f;
        transform.rotation = Quaternion.Euler(0f, 0f, num);
    }
}
