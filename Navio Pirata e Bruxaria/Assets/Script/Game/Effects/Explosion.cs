using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Spells/Explosion")]
public class Explosion : Effect
{
    public override void WhenChant(Target target)
    {
        target.SetState("Boom");
        Debug.Log("Darkness blacker than black and darker than dark,\nI beseech thee, combine with my deep crimson.\nThe time of awakening cometh.\nJustice, fallen upon the infallible boundary," +
            "\nappear now as an intangible distortions!\nI desire for my torrent of power a destructive force:a destructive force without equal!\nReturn all creation to cinders," +
            "and come frome the abyss!\nExplosion!");
    }

}
