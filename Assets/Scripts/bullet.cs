using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        GameObject loader = GameObject.Find("Spawner");
        loader.GetComponent<Loader>().numObjects = loader.GetComponent<Loader>().numObjects - 1;
        int indexOfRoid = loader.GetComponent<Loader>().createdRoids.IndexOf(collision.gameObject);
        loader.GetComponent<Loader>().createdRoids.RemoveAt(indexOfRoid);

    }
}
