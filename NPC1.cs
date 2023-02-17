using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;
    //Уровень NPC
    public int level = 1;
    //Скорость NPC
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
