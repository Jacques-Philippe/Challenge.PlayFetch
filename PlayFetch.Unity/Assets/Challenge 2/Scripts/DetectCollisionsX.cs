using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        var otherIsGround = other.gameObject.name == "Ground";
        var otherIsDog = other.gameObject.name.Contains("Dog");

        Debug.Log($"Colliding with {other.gameObject.name}");

        if (otherIsGround)
        {
            Debug.Log("Game over");
        }
        else if (otherIsDog)
        {
            Destroy(gameObject);
        }
    }
}
