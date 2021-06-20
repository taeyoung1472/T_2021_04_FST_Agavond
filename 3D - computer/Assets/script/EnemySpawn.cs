using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public int firstSpawnTime;
    public int SpawnDelay;
    public float y;
    public Vector2 Xpos;
    public Vector2 Zpos;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", firstSpawnTime, SpawnDelay);
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(Xpos.x, Xpos.y);
        float randomZ = Random.Range(Zpos.x, Zpos.y);
        GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, y, randomZ), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
    }
}
