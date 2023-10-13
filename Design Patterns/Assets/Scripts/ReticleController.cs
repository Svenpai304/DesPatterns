using UnityEngine;

public class ReticleController : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetToPoint(Vector3 point)
    {
        rectTransform.position = RectTransformUtility.WorldToScreenPoint(Camera.main, point);
    }

    public void SetToCenter()
    {
        rectTransform.position = new Vector2(Screen.width / 2, Screen.height / 2);
    }
}
