using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    private int num;
    private int numOfBalls = 20;
    private string txt = "Ball_";
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < numOfBalls; i++)
        {
            GameObject newBall = Instantiate(ball,new Vector3(transform.position.x - Random.Range(-0.9f,0.9f),transform.position.y + Random.Range(0, 0.9f), transform.position.z - Random.Range(-0.9f, 0.9f)),Quaternion.identity);
            newBall.name = txt + num.ToString();
            newBall.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            num++;
        }
        StartCoroutine(SpawnBall());
    }

    public IEnumerator SpawnBall()
    {
        while(true)
        {
            GameObject newBall = Instantiate(ball, new Vector3(transform.position.x - Random.Range(-0.9f, 0.9f), transform.position.y + Random.Range(0, 0.9f), transform.position.z - Random.Range(-0.9f, 0.9f)), Quaternion.identity);
            newBall.name = "Ball_" + num.ToString();
            newBall.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            num++;
            yield return new WaitForSeconds(1f);
        }
        
    }
}
