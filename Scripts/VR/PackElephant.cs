using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PackElephant : MonoBehaviour
{
    public GameObject animal;
    public int numOfAnimals = 20;
    public int radius = 100;

    private List<GameObject> _animals = new List<GameObject>();
    private List<Vector3> _positions = new List<Vector3>();

    private GameObject newAnimal;

    private Vector3 _position;

    public bool spawn = false;
    public bool deSpawn = false;
    // Start is called before the first frame update
    void Start()
    {
        _position = transform.position;
       using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawningCreatures : MonoBehaviour
{
    public int numOfAnimals = 20;
    public int radius = 100;
    public GameObject animals;

    public Vector2 regionSize;
    private List<Vector2> _points;

    private List<GameObject> _animals = new List<GameObject>();
    private List<Vector3> _positions = new List<Vector3>();

    private GameObject newAnimal;

    private Vector3 _position;

    public bool spawn = false;
    public bool deSpawn = false;
    // Start is called before the first frame update
    void Start()
    {
        _position = transform.position;
        _points = PoissonDistribution.GeneratePoints(radius, regionSize, numOfAnimals);
        //int n = Random.Range(7, numOfAnimals);
        foreach (Vector2 point in _points)
        {
            newAnimal = Instantiate(animals, new Vector3((point.x + _position.x), 1.82f, (point.y + _position.z) ), Quaternion.Euler(-90,30,0)) ;
            float rScale = (Random.Range(0.4f, 1.1f));
            newAnimal.transform.localScale = new Vector3(rScale, rScale, rScale);
            if(newAnimal) _animals.Add(newAnimal);
            //_positions()
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            SpawnEs();
            spawn = false;
        }
        if (deSpawn)
        {
            Despawn();
            deSpawn = false;
        }
    }
    //Don't remove this function you may need it if you have third person view
    void SpawnEs()
    {
        int n = Random.Range(7, numOfAnimals);
        for (int i = 0; i < n; i++)
        {
            newAnimal = Instantiate(animals, new Vector3((Random.Range(0,20) + _position.x), 0, (Random.Range(0,20) + _position.z) ), Quaternion.Euler(-90,30,0)) ;
            float rScale = (Random.Range(0.4f, 1.1f));
            newAnimal.transform.localScale = new Vector3(rScale, rScale, rScale);
            if(newAnimal) _animals.Add(newAnimal);
            //_positions()
        }
    }
    void Despawn()
    {
        Debug.Log("Despawn");
        int lastIndex = _animals.Count;
        for (int i = 0; i < lastIndex; i++)
        {
            Destroy(_animals[i]);
            _animals.RemoveAt(i);
        }
        
    }
}
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            SpawnEs();
            spawn = false;
        }
        if (deSpawn)
        {
            Despawn();
            deSpawn = false;
        }
    }
    
    void SpawnEs()
    {
        int n = Random.Range(7, numOfAnimals);
        for (int i = 0; i < n; i++)
        {
            newAnimal = Instantiate(animal, new Vector3((Random.Range(0,20) + _position.x), 0, (Random.Range(0,20) + _position.z) ), Quaternion.Euler(-90,30,0)) ;
            float rScale = (Random.Range(0.4f, 1.1f));
            newAnimal.transform.localScale = new Vector3(rScale, rScale, rScale);
            if(newAnimal) _animals.Add(newAnimal);
            //_positions()
        }
    }
    void Despawn()
    {
        Debug.Log("Despawn");
        int lastIndex = _animals.Count;
        for (int i = 0; i < lastIndex; i++)
        {
            Destroy(_animals[i]);
            _animals.RemoveAt(i);
        }
        
    }
}
