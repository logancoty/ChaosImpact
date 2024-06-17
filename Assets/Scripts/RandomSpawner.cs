using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject GoldCoin;
    public GameObject SilverCoin;
    public GameObject incomingObject;
    public GameObject Heart;
    public GameObject DoublePoints;
    float coinTimer = 0f;
    float incomingObjectTimer = 0f;
    float heartTimer = 0f;
    float DoublePointsTimer = 0f;

    void FixedUpdate()
    {
        coinTimer += Time.deltaTime;
        incomingObjectTimer += Time.deltaTime;
        heartTimer += Time.deltaTime;
        DoublePointsTimer += Time.deltaTime;

        if (coinTimer > 3)
        {
            int goldOrSilver = Random.Range(0, 2);
            SpawnCoinAtRandom(goldOrSilver);
            coinTimer = 0f;
        }

        if (incomingObjectTimer > 4)
        {
            SpawnIncomingObject();
            incomingObjectTimer = 0f;
        }

        if (heartTimer > 25)
        {
            SpawnHeart();
            heartTimer = 0f;
        }

        if (DoublePointsTimer > 35)
        {
            SpawnDoublePoints();
            DoublePointsTimer = 0f;
        }
    }

    void SpawnCoinAtRandom(int goldOrSilver)
    {

        float spawnX = Random.Range(-4f, 4f);
        float spawnY = Random.Range(1.5f, 4f);
        Vector3 randomPos = new Vector3(spawnX, spawnY, 0f);

        if (goldOrSilver == 1)
            Instantiate(GoldCoin, randomPos, Quaternion.identity);
        else
            Instantiate(SilverCoin, randomPos, Quaternion.Euler(90, 0, 0));
    }

    void SpawnIncomingObject()
    {
        float spawnY = Random.Range(.7f, 2.5f);
        Vector3 randomPos = new Vector3(0f, spawnY, 20f);
        Instantiate(incomingObject, randomPos, Quaternion.identity);
    }

    void SpawnHeart()
    {

        float spawnX = Random.Range(-4f, 4f);
        float spawnY = Random.Range(1.5f, 4f);
        Vector3 randomPos = new Vector3(spawnX, spawnY, 0f);
        Instantiate(Heart, randomPos, Quaternion.Euler(270, 0, 0));
    }

    void SpawnDoublePoints()
    {

        float spawnX = Random.Range(-4f, 4f);
        float spawnY = Random.Range(1.5f, 4f);
        Vector3 randomPos = new Vector3(spawnX, spawnY, 0f);
        Instantiate(DoublePoints, randomPos, Quaternion.Euler(270, 0, 0));
    }
}
