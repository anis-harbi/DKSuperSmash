using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject playerController;
    public float movementSpeed;
    public GameObject currentPlayer;
    public Animator currentPlayerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 0.18f;
        currentPlayerAnimator = currentPlayer.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow)){
            currentPlayerAnimator.Play("running");
            MovePlayer(currentPlayer, "left");
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            MovePlayer(currentPlayer, "right");
            currentPlayerAnimator.Play("running");
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            MovePlayer(currentPlayer, "forward");
            currentPlayerAnimator.Play("running");
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            MovePlayer(currentPlayer, "backward");
            currentPlayerAnimator.Play("running");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            currentPlayerAnimator.Play("punch");
        }
    }
     
    protected void MovePlayer(GameObject player, string direction)
    {
        switch (direction)
        {
            case "left":
                player.transform.position += new Vector3(-1.0f * movementSpeed, 0, 0);
                player.transform.rotation = Quaternion.Euler(new Vector3(0, -90.0f, 0));
                break;
            case "right":
                player.transform.position += new Vector3(+1.0f * movementSpeed, 0, 0);
                player.transform.rotation = Quaternion.Euler(new Vector3(0, 90.0f, 0));
                break;
            case "forward":
                player.transform.position += new Vector3( 0, 0, +1.0f * movementSpeed);
                player.transform.rotation = Quaternion.Euler(new Vector3(0, 0.0f, 0));
                break;
            case "backward":
                player.transform.position += new Vector3( 0, 0, -1.0f * movementSpeed);
                player.transform.rotation = Quaternion.Euler(new Vector3(0, 180.0f, 0));
                break;
        }


    }


}
