using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGenerator : MonoBehaviour
{
    public GameObject zombieGenerator;
    public GameObject zombie;
    private GameObject zombieClone;

    public float Timer = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            zombieClone = Instantiate(zombie, zombieGenerator.transform.position, zombieGenerator.transform.rotation) as GameObject;
            Timer = 10;
        }
    }
}
