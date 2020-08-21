using UnityEngine;

public class Gun : MonoBehaviour
{
    //Variable to adjust damage to inflict onto opponent
    public float damage = 0f;
    //Variable to adjust range we can hit something
    public float range = 100f;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();

            if(target !=null)
            {
                target.takeDamage(damage);
            }
        }
    }
}
