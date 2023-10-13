using UnityEngine;

public class Target : MonoBehaviour, ITargetable
{
    public Vector3 Position { get => transform.position; }
    public Vector3 Velocity { get => transform.position - previousPos; }
    private Vector3 previousPos;

    [SerializeField] private float maxMovement;

    private void FixedUpdate()
    {
        previousPos = transform.position;
        transform.position = new Vector3(Mathf.Sin(Time.time) * maxMovement, 0, 0);
    }

    public void OnTargeted() { }
}
