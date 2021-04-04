using UnityEngine;

public class Rotator : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
    }
}
