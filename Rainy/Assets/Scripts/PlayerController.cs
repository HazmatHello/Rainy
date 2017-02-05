using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public float maxSpeed = 10f;

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
    }

    public override void OnStartLocalPlayer()
    {
        Debug.Log("Player 1");
    }
}