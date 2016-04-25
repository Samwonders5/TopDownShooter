using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public Projectile projectile;
    public Transform muzzle;
    public float bulletSpeed;
    public float shootDelay;
    public AudioClip shootGun;

    private float nextFireTime;

    private AudioSource source;

    void Start ()
    {
        nextFireTime = 0;

        source = GetComponent<AudioSource>();
    }

    void Update ()
    {
        if (Input.GetMouseButton(0) && (Time.time >= nextFireTime))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Projectile bullet = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
        bullet.SetSpeed(bulletSpeed);
        nextFireTime = Time.time + shootDelay;
        source.PlayOneShot(shootGun);
    }
}
