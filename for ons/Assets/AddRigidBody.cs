using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidBody : MonoBehaviour
{
    int count2 = 0;
    public GameObject player;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
        if (other.gameObject.tag == "racket")
        {
            print("inside forcee ");
            // gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 3f)  ;
            gameObject.GetComponent<Rigidbody>().AddForce(player.transform.forward * 3f);


        }
    }
}
