using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public float maxSpeed = 10f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * maxSpeed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * maxSpeed;

        transform.Rotate(0, 0, 0);
        transform.Translate(x, y, 0);
<<<<<<< HEAD

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Fire();
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 6;

        Destroy(bullet, 2.0f);
    }

    public override void OnStartLocalPlayer()
    {
        Debug.Log("Player 1");
=======
        Debug.Log("moving");
>>>>>>> parent of 8d1453b... Update
    }
}