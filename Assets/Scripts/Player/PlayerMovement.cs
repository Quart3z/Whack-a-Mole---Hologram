using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController cc;
    float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag=="player1")
        {
            if (Input.GetKey(KeyCode.W))
                MoveForward(-moveSpeed);
            if (Input.GetKey(KeyCode.S))
                MoveForward(moveSpeed);

            if (Input.GetKey(KeyCode.A))
                MoveLeft(-moveSpeed);
            if (Input.GetKey(KeyCode.D))
                MoveLeft(moveSpeed);
        }
        if (gameObject.tag == "player2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
                MoveForward(-moveSpeed);
            if (Input.GetKey(KeyCode.DownArrow))
                MoveForward(moveSpeed);

            if (Input.GetKey(KeyCode.LeftArrow))
                MoveLeft(-moveSpeed);
            if (Input.GetKey(KeyCode.RightArrow))
                MoveLeft(moveSpeed);
        }


    }

    void MoveForward(float scale)
    {
        cc.Move(scale * Vector3.forward);
    }

    void MoveLeft(float scale)
    {
        cc.Move(scale * Vector3.left);
    }
}
