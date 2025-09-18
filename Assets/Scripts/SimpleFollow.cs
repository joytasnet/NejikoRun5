using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
    Vector3 diff;

    public Transform target;
    public float followSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diff = target.position - transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = target.position - diff;
        
        transform.position = Vector3.Lerp(
            transform.position,
            target.position-diff,
            Time.deltaTime*followSpeed
        );
        

    }
}
