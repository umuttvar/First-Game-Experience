using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeColor(Color.red);
            gameObject.tag = "Hit";
        }
    }

    void ChangeColor(Color a)
    {
        GetComponent<MeshRenderer>().material.color = a;
        
    }
}
