using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Backpack : Item
{
    public int space;

    public override void Use()
    {
        Equipment.Instance.addBackpack(this);
    }

    public override void Remove()
    {
        Equipment.Instance.removeBackpack(this);
    }
}