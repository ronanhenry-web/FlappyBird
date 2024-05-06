using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private float _maxTime;
    private float _heightRange = 2f;
    [SerializeField] private GameObject _pipe ;

    private float _timer;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
    }

    private void SpawnPipe()
    {
        float randomHeight = Random.Range(-_heightRange, _heightRange);
        Vector3 spawnPos = transform.position + new Vector3(0, randomHeight, 0);
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
