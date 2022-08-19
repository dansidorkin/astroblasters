using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public float asteroidMoveSpeed;
    public GameObject[] gameObject;
    public List<GameObject> createdRoids;
    public Vector3 randomLocation;
    public int numObjects;


    private void Start()
    {
        numObjects = 0;
    }
    private void Update()
    {
        //randomly selects a game object to instantiate based on array location
        System.Random rnd = new System.Random();
        int num = rnd.Next(1, gameObject.Length);

        //ensures that the asteroid spawns from a location outside the Camera
        //by assigning proper vector locations,

        randomLocation.x = rnd.Next(-30, 30);
        int de = rnd.Next(0, 2);
        if (de == 0) { 
            randomLocation.y = rnd.Next(-30, -6);
        }
        if (de == 1)
        {
            randomLocation.y = rnd.Next(6, 30);
        }
        randomLocation.z = 0;

        //generate the asteroid only if there are less than 10 asteroids in the scene
        if (numObjects < 10) {
            GameObject asteroid = Instantiate(gameObject[num], randomLocation, Quaternion.identity);
            createdRoids.Add(asteroid);
            numObjects++;
            //generate some force to send the asteriod towards the player
            GameObject player = GameObject.Find("Player");
            // player.transform.position
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            Vector2 playerLocation = rb.position;
            Rigidbody2D asteroidRB = asteroid.GetComponent<Rigidbody2D>();

            //if (de == 0)
            //{
            //    asteroidRB.AddForce(asteroidMoveSpeed * Time.deltaTime * -player.transform.position, ForceMode2D.Impulse);
            //    asteroid.transform.position = Vector2.MoveTowards(asteroid.transform.position, player.transform.position, asteroidMoveSpeed * Time.deltaTime);
            //}
            //if (de == 1)
            //{
            //    asteroidRB.AddForce(asteroidMoveSpeed * Time.deltaTime * player.transform.position, ForceMode2D.Impulse);
            //}
        }

        for (int i = 0; i < createdRoids.Count; i++)
        {
            if (createdRoids[i].transform.position.y < -10  || createdRoids[i].transform.position.y > 10 || createdRoids[i].transform.position.x > 15 || createdRoids[i].transform.position.x < -15)
            {
                Destroy(createdRoids[i]);
                createdRoids.RemoveAt(i);
                numObjects--;
            }
        }
    }
}