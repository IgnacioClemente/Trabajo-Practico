using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Objectpool : MonoBehaviour
{

    public GameObject prefabToPool;
    public int poolSize = 10;
    [HideInInspector]
    public List<GameObject> objectPool = new List<GameObject>();
    public List<GameObject> activePooledObjects = new List<GameObject>();
    void Start()
    {
        if (prefabToPool == null)
        {
            Debug.LogError("PrefabToPool is null. Assign reference in Inspector.");
        }

        for (int i = 0; i < poolSize; i++)
        {
            GameObject newGameObject = (GameObject)Instantiate(prefabToPool);
            newGameObject.name = "Enemy_" + i;
            newGameObject.transform.parent = this.transform;
            objectPool.Add(newGameObject);
            newGameObject.SetActive(false);

        }
    }

    public GameObject SpawnObject()
    {
        if (objectPool.Count <= 0)
        {
            Debug.LogError("No more objects pooled to spawn");
            return null;
        }
        int i = objectPool.Count - 1;
        activePooledObjects.Add(objectPool[i]);
        int j = activePooledObjects.Count - 1;
        objectPool.RemoveAt(i);
        activePooledObjects[j].transform.position = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        activePooledObjects[j].SetActive(true);
        return activePooledObjects[j];
    }
}
