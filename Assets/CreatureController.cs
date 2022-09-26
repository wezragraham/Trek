using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    [SerializeField]
    GameObject rightFront, leftFront, rightRear, leftRear;

    float rotationSpeed = 100;

    [SerializeField]
    float rightFrontInput, leftFrontInput, rightRearInput, leftRearInput;
    // Start is called before the first frame update
    void Start()
    {
        rightFront = GameObject.Find("RightFrontLeg");
        leftFront = GameObject.Find("LeftFrontLeg");
        rightRear = GameObject.Find("RightRearLeg");
        leftRear = GameObject.Find("LeftRearLeg");
    }

    // Update is called once per frame
    void Update()
    {
        rightFrontInput = Input.GetAxis("RightFront");
        leftFrontInput = Input.GetAxis("LeftFront");
        rightRearInput = Input.GetAxis("RightRear");
        leftRearInput = Input.GetAxis("LeftRear");

        rightFront.transform.RotateAround(rightFront.transform.GetChild(0).position, Vector3.forward, rightFrontInput * rotationSpeed * Time.deltaTime);
        leftFront.transform.RotateAround(leftFront.transform.GetChild(0).position, Vector3.forward, leftFrontInput * rotationSpeed * Time.deltaTime);
        rightRear.transform.RotateAround(rightRear.transform.GetChild(0).position, Vector3.forward, rightRearInput * rotationSpeed * Time.deltaTime);
        leftRear.transform.RotateAround(leftRear.transform.GetChild(0).position, Vector3.forward, leftRearInput * rotationSpeed * Time.deltaTime);
    }
}
