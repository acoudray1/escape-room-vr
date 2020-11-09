using System.Collections;
using UnityEngine;

public class InteractiveSlideObject : InteractiveObject
{
    [SerializeField] private Vector3 openPosition, closedPosition;
    [SerializeField] private float animationTime;

    private Hashtable iTweenArgs;

    public override void Start()
    {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("isLocal", true);

        base.Start();
    }

    protected override void EClickActionOpeningCase()
    {
        iTweenArgs["position"] = openPosition;
        base.EClickActionOpeningCase();
    }

    protected override void EClickActionClosureCase()
    {
        iTweenArgs["position"] = closedPosition;
        base.EClickActionClosureCase();
    }

    protected override void EClickActionCommonCase()
    {
        base.EClickActionCommonCase();
        iTween.MoveTo(gameObject, iTweenArgs);
    }
}
