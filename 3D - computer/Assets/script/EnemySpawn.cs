using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject Enemy;

    public int firstSpawnTime;
    public int SpawnDelay;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", firstSpawnTime, SpawnDelay);
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-175f, 175f);
        float randomZ = Random.Range(-175f, 175f);

        GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, y, randomZ), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
