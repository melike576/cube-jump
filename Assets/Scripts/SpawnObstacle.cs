using System.Collections;
using UnityEngine;
using TMPro;

/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */


public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] GameObject[] obsatclePrefab;
    [SerializeField] TMP_Text scoreText;
    float initialSpeed = 10f;
    float maxSpeed = 35f;
    float speedIncreaseRate = 1f;
    float timeElapsed = 0f;
    int score = 0;
    float scoreIncreaseRate = 1f;

    void Start()
    {
        StartCoroutine(SpawnObstacles());
        StartCoroutine(DelayedOperation());


    }
    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            float randomDelay = Random.Range(0.7f, 3f);
            yield return new WaitForSeconds(randomDelay);
            int i = Random.Range(0, obsatclePrefab.Length);
            Vector3 spawnPosition = transform.position;
            if(i==1 )
            {
                spawnPosition.y += 1;
            }
            GameObject obstacle = Instantiate(obsatclePrefab[i],spawnPosition,Quaternion.identity);
            Obstacle obstacleScript=obstacle.GetComponent<Obstacle>();
            if(obstacleScript !=null)
            {
                obstacleScript.SetSpeed(initialSpeed);
            }

        }



    }

    void IncreaseSpeed()
    {
        initialSpeed += speedIncreaseRate;
            if(initialSpeed>maxSpeed)
        {
            initialSpeed = maxSpeed;
        }
        scoreIncreaseRate = initialSpeed / 10f;
    }
    IEnumerator DelayedOperation()
    {
        while(true)
        {
            score += 1;
            scoreText.text = "SCORE: " + score.ToString();
            yield return new WaitForSeconds(1f / scoreIncreaseRate);
        }



    }

    private void FixedUpdate()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed>=5f)
        {
            timeElapsed = 0;
            IncreaseSpeed();
        }
    }
}
