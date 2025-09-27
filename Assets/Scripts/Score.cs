using UnityEngine;

public class Score : MonoBehaviour
{
    int dumpedTimes = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            HowManyTimesDumbped(dumpedTimes);
            dumpedTimes++;
        }
    }

    void HowManyTimesDumbped(int a)
    {
        Debug.Log("Carpma sayisi: " + a);
    }

}
