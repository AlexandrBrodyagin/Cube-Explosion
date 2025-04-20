using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private int _minCountCubes = 2;
    private int _maxCountCubes = 6;
    private float _spawnRadius = 0.5f;
    private float _explosionForce = 300f;
    private float _explosionRadius = 2f;
    private float _sizeReduction = 0.5f;
    private float _splitChanseReduction = 0.5f;

    public void Spawn(Vector3 scale)
    {
        int cubeCounts = Random.Range(_minCountCubes, _maxCountCubes + 1);

        for (int i = 0; i < cubeCounts; i++)
        {
            Vector3 position = transform.position + Random.insideUnitSphere * _spawnRadius;

            GameObject newCube = Instantiate(_cubePrefab, position, Quaternion.identity);

            newCube.transform.localScale = transform.localScale * _sizeReduction;
            newCube.AddComponent<CubeSpawner>();

            CubeSplitter splitter = newCube.AddComponent<CubeSplitter>();

            splitter.SplitChance = splitter.SplitChance * _splitChanseReduction;

            Rigidbody rigidbody = newCube.AddComponent<Rigidbody>();
            rigidbody.useGravity = true;

            rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }

        Destroy(gameObject);
    }
}
