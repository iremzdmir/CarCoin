using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider RearLeftWheel;
    public WheelCollider RearRightWheel;

    public GameObject FrontLeftWheels;
    public GameObject FrontRightWheels;
    public GameObject RearLeftWheels;
    public GameObject RearRightWheels;

    public float maxMotorGucu;
    public float maxDonusAcisi;
    public float motor;
    AudioSource audioSource;
    public GameObject FinishScreen;
    public bool canMove = true;

    void Start()
    {
        FinishScreen = GameObject.Find("FinishScreen");
        FinishScreen.SetActive(false);
        
        audioSource = GetComponent<AudioSource>();

    }

   


    void Update()
    {

        motor = maxMotorGucu * Input.GetAxis("Vertical");
        float donus = maxDonusAcisi * Input.GetAxis("Horizontal");

        FrontLeftWheel.steerAngle = FrontRightWheel.steerAngle = donus;
        RearLeftWheel.motorTorque = motor;
        RearRightWheel.motorTorque = motor;

        Teker();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            audioSource.Play();

        }

        if(other.gameObject.tag=="parkzemin")
        {
            FinishScreen.SetActive(true);
            canMove = false;
        }
    }

    void Teker()
    {
        Quaternion rot;
        Vector3 pos;
        FrontLeftWheel.GetWorldPose(out pos, out rot);
        FrontLeftWheels.transform.position = pos;
        FrontLeftWheels.transform.rotation = rot;

        FrontRightWheel.GetWorldPose(out pos, out rot);
        FrontRightWheels.transform.position = pos;
        FrontRightWheels.transform.rotation = rot;

        RearLeftWheel.GetWorldPose(out pos, out rot);
        RearLeftWheels.transform.position = pos;
        RearLeftWheels.transform.rotation = rot;

        RearRightWheel.GetWorldPose(out pos, out rot);
        RearRightWheels.transform.position = pos;
        RearRightWheels.transform.rotation = rot;

    }



   
}
