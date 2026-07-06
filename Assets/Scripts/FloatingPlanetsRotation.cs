using UnityEngine;

public class PlanetDisplayRotation : MonoBehaviour
{
public float speed = 20f;


void Update()
{
    transform.Rotate(Vector3.up * speed * Time.deltaTime);
}


}
