using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [Range(0f, 1f)]
    public float ParallaxFactor = 0.5f;

    private Transform cam;
    private Vector3 previousCamPos;

    private void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.position;
    }

    private void LateUpdate()
    {
        Vector3 delta = cam.position - previousCamPos;
        transform.position += new Vector3(delta.x * ParallaxFactor, delta.y * ParallaxFactor, 0f);
        previousCamPos = cam.position;
    }
}