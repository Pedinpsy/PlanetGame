using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocity;
    public float rotation;
    private Transform sprite;
    // Use this for initialization
    void Start()
    {
        sprite = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animation();
    }

    public void Move()
    {

        transform.Translate(Vector3.right * velocity);

    }

    private void Animation()
    {
       // sprite.Rotate(Vector3.forward * rotation);



    }
}
