using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    [SerializeField]
    private float maxTime = 1.5f;
    [SerializeField]
    private float range = 0.45f;
    [SerializeField]
    private GameObject obstacle;

    public float time;


    // Start is called before the first frame update
    void Start()
    {
        SpawObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            SpawObstacle();
            time = 0;
        }
        time += Time.deltaTime;
    }

    void SpawObstacle()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-range, range));
        GameObject _obstacle = Instantiate(obstacle, spawnPos, Quaternion.identity);

        Destroy(_obstacle, 10f);
    }

}
