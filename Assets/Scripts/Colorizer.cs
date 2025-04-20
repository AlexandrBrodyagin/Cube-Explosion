using UnityEngine;

public class Colorizer : MonoBehaviour
{
    void Awake()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV();
    }
}
