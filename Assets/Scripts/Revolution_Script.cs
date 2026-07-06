using UnityEngine;

public class OrbitRevolution : MonoBehaviour
{
    public float orbitSpeed = 10f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}