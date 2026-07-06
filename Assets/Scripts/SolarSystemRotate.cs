using UnityEngine;

public class HologramRotate : MonoBehaviour
{
void Update()
{
transform.Rotate(0, 15 * Time.deltaTime, 0);
}
}
