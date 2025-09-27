using UnityEngine;

public class Dropper : MonoBehaviour
{
    float waitTime = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > waitTime)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;  
        }
    }
}
