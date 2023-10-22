using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected List<Transform> prefabObjs = new List<Transform>();
    [SerializeField] public List<Transform> poolObjs = new List<Transform>();

    protected static Spawner instance;

    public static Spawner Instance { get { return instance; } }

    private void Reset()
    {
        LoadComponent();
    }
    private void Awake()
    {
        instance = this;
    }
    protected virtual void LoadComponent()
    {
        LoadPrefabs();
    }
    protected virtual void LoadPrefabs()
    {
        Transform prefabs = transform.Find("Prefabs");
        foreach (Transform t in prefabs)
        {
            t.gameObject.SetActive(false);
            prefabObjs.Add(t);
        }
    }
    public virtual Transform Spawn(string name, Vector3 pos, Quaternion ro)
    {
        foreach(Transform obj in poolObjs)
        {
            if(obj.name == name)
            {
                Debug.Log("get from pool");
                obj.transform.position = pos;
                obj.gameObject.SetActive(true);
                poolObjs.Remove(obj);
                return obj;
            }
        }
        Transform prefab = prefabObjs[0];
        Transform tmp = Instantiate(prefab, pos, ro);
        return tmp;
    }
}
