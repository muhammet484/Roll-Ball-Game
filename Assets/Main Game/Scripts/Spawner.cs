using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Vector2 AreaSize;
    [SerializeField] GameObject cube;
    public GameObject SpawnObject()
    {
        Vector3 someWhere = new Vector3(
            Random.Range(AreaSize.x / 2, -AreaSize.x / 2),
            1.25f,
            Random.Range(AreaSize.y / 2, -AreaSize.y / 2)
            );
        return Instantiate(cube, someWhere, Quaternion.identity);
    }
}
