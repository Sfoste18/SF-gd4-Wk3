using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 40.0f;
    private float topBound = 24;

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

    }
}