using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {

        TimerMethod();
        Shoot();





        if (_canShoot)
        {
            currentTime -= Time.deltaTime;

            if (currentTime < 0)
            {
                _canShoot = true;
                currentTime = Timer;
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }


    
    private void TimerMethod()
    {
        if (_canShoot)
        {
            currentTime -= Time.deltaTime;

            if (currentTime < 0)
            {
                _canShoot = true;
                currentTime = Timer;
            }
        }
    }

     private void Shoot()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }
}