using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReferences;

    private GameObject spawnEnemy;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, enemyReferences.Length);
            randomSide = Random.Range(0, 2);

            spawnEnemy = Instantiate(enemyReferences[randomIndex]);

            if (randomSide == 0)
            {
                spawnEnemy.transform.position = leftPos.position;
                spawnEnemy.GetComponent<Enemy>().speed = Random.Range(4, 10);
            }
            else
            {
                spawnEnemy.transform.position = rightPos.position;
                spawnEnemy.GetComponent<Enemy>().speed = -Random.Range(4, 10);
                spawnEnemy.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
