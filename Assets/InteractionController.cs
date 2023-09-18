using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public static InteractionController Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public GameObject InteractionUI;
    public List<IInteractable> objectsInteractablesNear;
    public IInteractable objectToInteract;

    private void Start()
    {
        StartCoroutine(CheckInteractablesAround());
    }

    public void ShowInteractionMessage(IInteractable item)
    {
        InteractionUI.SetActive(true);
        objectsInteractablesNear.Add(item);
    }

    IEnumerator CheckInteractablesAround()
    {
        while (true)
        {
            CheckNearestInteractable();
            print("you suck at this, just like me");
            yield return new WaitForSeconds(0.1f);
        }
    }

    void CheckNearestInteractable()
    {
        // Initialize distance to a high value.
        float distance = float.MaxValue;
        IInteractable nearestInteractable = null;

        // For each item in the list, check the distance with the player
        foreach (IInteractable item in objectsInteractablesNear)
        {
            // Calculate the direction from the player to the interactable object.
            Vector2 direction = item.transform.position - transform.position;

            // Cast a ray to check for obstacles between the player and the interactable.
            int layerMask = LayerMask.GetMask("InteractionLayer");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction.normalized, direction.magnitude, layerMask);

            // Debugging: Draw the ray.
            Debug.DrawRay(transform.position, direction.normalized * direction.magnitude, Color.red, 2.0f);

            if (hit.collider != null)
            {
                // Debugging: Print the distance and object names.
                print("Distance to " + item.name + ": " + hit.distance);

                // Check if this object is closer than the previously nearest one.
                if (hit.distance < distance)
                {
                    distance = hit.distance;
                    nearestInteractable = item;
                }
            }
            else
            {
                // Debugging: If the ray didn't hit anything, print a message.
                print("Raycast to " + item.name + " did not hit.");
            }
        }

        if (nearestInteractable != null)
        {
            // Debugging: Print the nearest interactable object.
            print("Nearest interactable: " + nearestInteractable.name);
            objectToInteract = nearestInteractable;
        }
        else
        {
            // Debugging: Print a message if no interactable objects were found.
            print("No interactable objects found.");
        }
    }

    public void HideInteractionMessage(IInteractable item)
    {
        objectsInteractablesNear.Remove(item);
        // This is because when the player is in the area where two objects can be interacted,
        // when unfocusing one of them but still focusin the other, the pop up disappeared
        if (objectsInteractablesNear.Count == 0) InteractionUI.SetActive(false);
    }

    public void InteractPrimaryUse()
    {
        CheckNearestInteractable();
        objectToInteract.PrimaryUse();
    }
}
