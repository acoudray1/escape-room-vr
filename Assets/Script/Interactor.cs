using System.Collections;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    // Max distance to interact with the object
    [SerializeField] private float interactRange;

    private InteractiveObject interactiveObject;
    private Camera cam;
    private RaycastHit hit;
    private ReticleController reticleController;

    void Start()
    {
        cam = Camera.main;
        reticleController = GameObject.FindObjectOfType<ReticleController>();
    }

    public void Update()
    {
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
        if (hit.transform)
        {
            interactiveObject = hit.transform.GetComponent<InteractiveObject>();
        } else {
            interactiveObject = null;
        }

        reticleController.ShowIcon(interactiveObject);

        if (Input.GetKeyDown(KeyCode.E) && interactiveObject)
        {
            interactiveObject.PerformAction();
        }
    }
}
