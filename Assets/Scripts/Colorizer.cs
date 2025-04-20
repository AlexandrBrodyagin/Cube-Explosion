using UnityEngine;

public class Colorizer : MonoBehaviour
{
    void Awake()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        renderer.material.color = randomColor;
    }
}
