using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propel : MonoBehaviour
{
    public float asteroidMoveSpeed;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, asteroidMoveSpeed * Time.deltaTime);
    }
}
