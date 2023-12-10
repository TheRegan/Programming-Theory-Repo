using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    [SerializeField] private float secondsBetweenSpawns;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAfterWait());
    }

    private IEnumerator SpawnAfterWait()
    {
        Vector3 spawnPoint = new Vector3(transform.position.x, transform.position.y, Random.Range(minZ, maxZ));
        yield return new WaitForSeconds(secondsBetweenSpawns);
        Instantiate(objectToSpawn, spawnPoint, Random.rotation);
        StartCoroutine(SpawnAfterWait());
    }
}
