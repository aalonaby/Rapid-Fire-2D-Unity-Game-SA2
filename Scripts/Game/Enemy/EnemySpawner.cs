using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime; // Added missing field

    private float _timeUntillSpawn;

    void Awake()
    {
        SetTimeUntillSpawn();
    }

    void Update()
    {
        _timeUntillSpawn -= Time.deltaTime;

        if (_timeUntillSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntillSpawn();
        }
    }

    private void SetTimeUntillSpawn()
    {
        _timeUntillSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
