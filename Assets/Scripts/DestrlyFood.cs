using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrlyFood : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bear"))
        {
            Destroy(gameObject);
            Debug.Log("Juice");
        }

        if (collision.collider.CompareTag("Floor"))
        {
            Destroy(gameObject);
            Debug.Log("no Juice");
        }
    }
}
