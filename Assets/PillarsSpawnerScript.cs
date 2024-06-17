using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarsSpawnerScript : MonoBehaviour
{

    public GameObject pillar;
    public float spawnRate = 2;
    private float timer = 0;
    public float pillarOffset = 13.3f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPillar();
    }
    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPillar();
            timer = 0;
        }  
    }

    void spawnPillar()
    {
        float highPoint = transform.position.y + pillarOffset;
        float lowPoint =  transform.position.y - pillarOffset;

        Instantiate(pillar, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }
}
