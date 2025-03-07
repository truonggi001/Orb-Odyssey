using UnityEngine;

public class OrbBlue : Orb
{
    // INHERITANCE
    void Start()
    {
        OrbColor = Color.blue;
        GetComponent<Renderer>().material.color = OrbColor;
    }

    // POLYMORPHISM
    public override void ApplyEffect(PlayerControl player)
    {
        ApplyBaseEffect(player); // Apply color change
        player.transform.localScale += new Vector3(1.2f, 1.2f, 1.2f); // Increase size
    }
}