using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeTower : basicTowerScript
{

    // Start is called before the first frame update

    void Start()
    {
        Invoke();

    }

    // Update is called once per frame
    void Update()
    {
        track();
    }

    public override void Shoot()
    {
        GameObject stinger = (GameObject)Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        stingerScript sting = stinger.GetComponent<stingerScript>();

        if (sting != null)
        {
            sting.Seek(target);
        }
    }
}
