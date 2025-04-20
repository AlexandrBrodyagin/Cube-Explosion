using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    private CubeSpawner spawner;
    private float _splitChance = 1f;

    public float SplitChance
    {
        get
        {
            return _splitChance;
        }
        set
        {
            _splitChance = value;
        }
    }

    private void Start()
    {
        spawner = GetComponent<CubeSpawner>();
    }

    public void Split()
    {
        if (Random.value < SplitChance)
        {
            spawner.Spawn(transform.localScale);
        }

        Destroy(gameObject);
    }
}
