using System.Collections;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    [SerializeField] protected bool isOpen = false;

    public AudioClip openingSound;
    public AudioClip closingSound;

    protected AudioSource actionSound;

    public virtual void Start()
    {
        actionSound = GetComponent<AudioSource>();
    }

   public void PerformAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.EClickAction();
        }
    }

    protected void EClickAction()
    {
        if (isOpen)
        {
            EClickActionClosureCase();
        }
        else
        {
            EClickActionOpeningCase();
        }

        EClickActionCommonCase();
    }

    protected virtual void EClickActionOpeningCase()
    {
        actionSound.clip = openingSound;
    }

    protected virtual void EClickActionClosureCase()
    {
        actionSound.clip = closingSound;
    }

    protected virtual void EClickActionCommonCase()
    {
        isOpen = !isOpen;
        actionSound.Play();
    }
}
