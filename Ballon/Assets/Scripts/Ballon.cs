using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Ballon : MonoBehaviour
{
    public float balloonStrength = 2.4f;
    public bool playerSpawned = false;
    public bool respawn = false;
    public float timer = 3f;
    private bool popRespawn = false;

    private Vector3 savedPos;
    private float savedTimer;

     public Ballon(){

     }
    // Start is called before the first frame update
    void Start()
    {
        savedPos = this.transform.position;
        savedTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (popRespawn)
        {
            this.transform.position = new Vector3(0, 0, 0);
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timer = savedTimer;
                this.transform.position = savedPos;
                popRespawn = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            ThirdPersonController tpc = other.gameObject.GetComponent(typeof(ThirdPersonController)) as ThirdPersonController;
            tpc.goUp(balloonStrength);
            if (respawn)
            {
                popRespawn = true;
            } else
            {
                Destroy(gameObject);
            }
        }
    }
}
