using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMoving : MonoBehaviour
{
    private GameObject loader;
    private GameObject player;
    public float asteroidMoveSpeed;
    private void Start()
    {
        loader = GameObject.Find("Spawner");
        asteroidMoveSpeed = loader.GetComponent<Loader>().asteroidMoveSpeed;
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        // gameObject.GetComponent<Rigidbody2D>().AddForce(5 * Time.deltaTime * player.transform.position, ForceMode2D.Impulse);
    }
}
