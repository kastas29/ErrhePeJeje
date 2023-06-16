using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewUsable", menuName = "Items/Usables")]
public class UsableItem : Item
{
    public UnityEvent evento;

    public override void Remove()
    {
        throw new System.NotImplementedException();
    }

    public override void Use()
    {
        evento.Invoke();
    }
}
