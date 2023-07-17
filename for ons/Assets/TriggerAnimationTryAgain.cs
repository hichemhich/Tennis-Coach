using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationTryAgain : MonoBehaviour


{
    public Animator anim;
    public AudioClip goodjob;
    public AudioClip aww;
    public AudioSource audio;
    int count1 = 0;
    int count2 = 0;

    
   // public bool alreadyPlayed = false;
   //  public bool alreadyPlayed1 = false;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {



    }

 



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "t")
        {
            if (count1 == 0)
            {
                count1++;
                anim.SetBool("IsTry", true);
                audio.PlayOneShot(aww);
            }
            
           // alreadyPlayed = true;
          //  alreadyPlayed1 = true;
        }


        if (other.tag == "g")
        {
            if(count1 == 0)
            {
                count1++;
                anim.SetBool("IsTry 1", true);
                audio.PlayOneShot(goodjob);
            }
           ;
         //   alreadyPlayed = true;
           // alreadyPlayed1 = true;
        }


       
        /*  if (!alreadyPlayed)
         {
             alreadyPlayed = true;
         }
         if (!alreadyPlayed1)
         {
             alreadyPlayed1 = true;
         }*/


    }
}
