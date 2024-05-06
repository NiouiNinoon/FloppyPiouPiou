using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _maxTime = 1.5f;
    private float _height = 0.45f;
    public GameObject _pipe;
    private float _timer;

    // Start is called before the first frame update
    private void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 pos = transform.position + new Vector3(0, Random.Range(-_height, _height));
        GameObject pipeInstance = Instantiate(_pipe, pos, Quaternion.identity);

        Destroy(pipeInstance, 10f);
    }
}