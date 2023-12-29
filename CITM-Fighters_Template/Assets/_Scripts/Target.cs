using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        var attack = other.GetComponent<Attack>();

        if (attack != null)
        {

            // Get the root (highest parent) of the current GameObject
            Transform rootTransform = GetRootParent(transform);

            // Check if the root object exists
            if (rootTransform != null)
            {
                // Check the tag of the root object
                string rootTag = rootTransform.tag;

                // Increment the score based on the root's tag
                switch (rootTag)
                {
                    case "Azri":
                        EvilAzriScoreScript.scoreValue += 100;
                        
                        break;

                    case "Evil Azri":
                        AzriScoreScript.scoreValue += 100;
                        break;

                    // Add more cases for other root tags if needed

                    default:
                        // Default case if the tag doesn't match any expected value
                        break;


                }

            }

            Debug.Log(other.name);
            GetComponentInParent<PlayerController>().OnHit(other.transform);
        }
            
    }

    private Transform GetRootParent(Transform currentTransform)
    {
        Transform parent = currentTransform;

        // Traverse up the hierarchy until there is no parent
        while (parent.parent != null)
        {
            parent = parent.parent;
        }

        return parent;
    }

}
