using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnbullet;
    public cannonLogic infoBullet;

    public void BulletShoot()
    {
        GameObject bulletCannon = bullet;
        bulletCannon.GetComponent<Rigidbody>().mass = infoBullet.bulletWeight;
        bulletCannon.GetComponent<Bullet>().speed = infoBullet.cannonForce;
        Instantiate(bulletCannon, spawnbullet.position, spawnbullet.rotation);
    }
    private void Start()
    {
        BulletShoot();
    }
}
