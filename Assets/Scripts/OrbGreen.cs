using UnityEngine;

public class OrbGreen : Orb
{
    // INHERITANCE
    void Start()
    {
        OrbColor = Color.green;
        GetComponent<Renderer>().material.color = OrbColor;
    }

    // POLYMORPHISM
    public override void ApplyEffect(PlayerControl player)
    {
        ApplyBaseEffect(player); // Apply color change
        player.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f); // Reduce size
        // Ensure scale doesn't go below a minimum (e.g., 0.1) to avoid disappearing
        player.transform.localScale = Vector3.Max(player.transform.localScale, new Vector3(0.1f, 0.1f, 0.1f));
    }
}