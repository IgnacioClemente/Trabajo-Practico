using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

    public Objectpool objectPool;

    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectPool.SpawnObject();
        }
    }
}
