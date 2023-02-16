using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Ballon : MonoBehaviour
{
    public float ballonStrength = 2.4f;
    public bool playerSpawned = false;

     public Ballon(){

     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Player"){
        ThirdPersonController tpc = other.gameObject.GetComponent(typeof(ThirdPersonController)) as ThirdPersonController;
        tpc.goUp(ballonStrength);
        Destroy(gameObject);
        }
    }
}
