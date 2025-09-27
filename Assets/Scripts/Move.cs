using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
   
    void Update()
    {
        MoveBox();
    }

    void MoveBox()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
