using UnityEngine;

public class CubeClicker : MonoBehaviour
{
    private CubeSplitter splitter;
    private void Start()
    {
        splitter = GetComponent<CubeSplitter>();
    }
    private void OnMouseDown()
    {
            splitter.Split();
    }
}
