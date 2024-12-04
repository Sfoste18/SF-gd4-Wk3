using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float xRange = 20;
    public float zRange = 20;

    public GameObject projectile;

   

    // Update is called once per frame
    void Update()
    {

        //Method 1
        //Player Horizontal Movement
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);

        //Player Forward Movement
        //forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * movementSpeed);


        //Method 2
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(horizontalMove, 0, verticalMove).normalized;
        transform.Translate(moveDir * movementSpeed * Time.deltaTime);



        //Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //Spawning projectiles 
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectile, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
        }






    }
}