using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider[] attackColliders;
    void Start()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void EnableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    void DisableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }
}
