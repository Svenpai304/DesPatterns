using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public void LookAtPoint(Vector3 point)
    {
        transform.rotation = Quaternion.LookRotation(point - transform.position);
    }
}
