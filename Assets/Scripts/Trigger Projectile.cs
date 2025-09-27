using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] List<GameObject> projectiles = new List<GameObject>();
    
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < projectiles.Count; i++) {
                projectiles[i].SetActive(true);
            }
        }
    }

}
