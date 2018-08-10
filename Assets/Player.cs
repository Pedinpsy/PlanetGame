using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity;
    public float rotation;
    private Transform sprite;
    public GameObject bullet;
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
        OnFire();




    }
    private void OnFire()
    {

        if (Input.GetButton("Fire1"))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 vectorToTarget = mousePosition - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            //Vector3 rotation =  * Vector3.forward;
            GameObject.Instantiate(bullet, transform.position, q);
        }
    }

    private void Move()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * velocity, Input.GetAxis("Vertical") * velocity));
    }
    private void Animation()
    {
        sprite.Rotate(Vector3.forward * rotation);



    }
}
