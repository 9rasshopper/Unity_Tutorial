using UnityEngine;

public class Pinball_Manager : MonoBehaviour
{
    public Rigidbody2D LeftBarRb;
    public Rigidbody2D RightBarRb;

    public int totalScore = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            LeftBarRb.AddTorque(30f);
       
        else 
            LeftBarRb.AddTorque(-30f);

        if (Input.GetKey(KeyCode.P))
            RightBarRb.AddTorque(-30f);
        else
            RightBarRb.AddTorque(30f);
    }



}
