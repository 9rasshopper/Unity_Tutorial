using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet; // Target planet to revolve around
    public float rotSpeed = 50f; // Rotation speed in degrees per second
    public float revolSpeed  = 100f; // Revolution speed in degrees per second
    public bool isRevolution = false;

    void Update()
    {

        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        //자기 자신 회전하는 기능
        if (isRevolution == true)
        { 
            transform.RotateAround(targetPlanet.position, Vector3.up, revolSpeed * Time.deltaTime);
        }
    }
}
