using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    // Start is called before the first frame update


    public HingeJoint2D Joint;
    public HingeJoint2D Joint2;
    public AudioClip Source;
    AudioSource audioSource;

    








void Start()

    {


        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnMouseOver()
    {

        Debug.Log("OnTriggerEnter2D");
        if (Joint.enabled == true)
        {
            audioSource.PlayOneShot(Source, 0.7F);
        }
        Joint.enabled = false;

        
    }

}
