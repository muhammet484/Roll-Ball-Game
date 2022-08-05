using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffect : MonoBehaviour
{
    [SerializeField] GameObject particle;
    [SerializeField] GameManager gameManager;
    [SerializeField] Spawner spawner;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == GameManager.CubeTriggerLayerID)
        {
            Destroy(
            Instantiate(particle, other.transform.position, Quaternion.identity),2);
            Destroy(other.transform.parent.gameObject);
            gameManager.Score++;
            spawner.SpawnObject();
        }
    }
}
