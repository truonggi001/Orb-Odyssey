using UnityEngine;

public class OrbRed : Orb
{
    // INHERITANCE
    void Start()
    {
        OrbColor = Color.red;
        GetComponent<Renderer>().material.color = OrbColor;
    }

    // POLYMORPHISM
    public override void ApplyEffect(PlayerControl player)
    {
        ApplyBaseEffect(player); // Apply color change
        player.Speed += 2f; // Increase speed
    }
}