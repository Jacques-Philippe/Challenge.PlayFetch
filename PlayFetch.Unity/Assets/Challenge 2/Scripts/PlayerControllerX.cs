using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    /// <summary>
    /// The delay between dog spawns
    /// </summary>
    private float delay = 3.0f;

    private bool isLocked = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpawnDog());
        }
    }

    IEnumerator SpawnDog()
    {
        if (!isLocked)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            isLocked = true;
            yield return new WaitForSeconds(delay);
            isLocked = false;
        }
    }
}
