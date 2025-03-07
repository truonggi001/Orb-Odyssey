using UnityEngine;

public abstract class Orb : MonoBehaviour
{
    public Color OrbColor;

    // ABSTRACTION
    public abstract void ApplyEffect(PlayerControl player);

    // POLYMORPHISM
    public virtual void ApplyBaseEffect(PlayerControl player)
    {
        // Default effect: Change player color to the orb's color
        Renderer renderer = player.GetComponent<Renderer>();
        if (renderer != null) renderer.material.color = OrbColor;
    }

    void Start()
    {
        // Apply the orb's color to its renderer
        GetComponent<Renderer>().material.color = OrbColor;
    }
}