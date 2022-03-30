using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBTWShots;

    void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        
        if (timeBtwShots <= 0)
        {
            if(Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBTWShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
