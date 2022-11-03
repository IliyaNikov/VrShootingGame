using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{

    public GameObject zombie;

    public GameObject player;

    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.hasChanged)
        {
            targetPosition = player.transform.position;
        }
        zombie.transform.position = Vector3.MoveTowards(zombie.transform.position, new Vector3(targetPosition.x, 26f, targetPosition.z), 0.006f);
        zombie.transform.LookAt(player.transform);
    }
}
