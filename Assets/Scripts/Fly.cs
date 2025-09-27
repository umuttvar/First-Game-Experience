using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 15f;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive (false);
    }

    void Start()
    {
        
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyObjectWhenReached();
    }


    void DestroyObjectWhenReached()
    {
        if (transform.position == playerPosition)
        {

            Destroy(gameObject);
        }
    }
    
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

}
