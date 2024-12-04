using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed;
    public float xRange, zRange;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.z > zRange || transform.position.z < -zRange)
        {
            //Either of the four conditions need to be true for the code to be executed
            Destroy(gameObject);
        }

        if (transform.position.x > xRange && transform.position.x < -xRange)
        {
            //Both of the conditions need to ge true for this code to execute
        }
        
    }
}
