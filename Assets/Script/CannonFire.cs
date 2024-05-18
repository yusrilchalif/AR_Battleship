using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public ParticleSystem[] cannonParticlesArray; // Array of your Particle Systems
    public ParticleSystem smokeParticles; // Reference to the smoke Particle System
    public float particleLifetime = 2.0f; // Lifetime of the particles (in seconds)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Change this to your desired input key
        {
            FireCannons();
        }
    }

    public void FireCannons()
    {
        foreach (ParticleSystem cannonParticles in cannonParticlesArray)
        {
            // Instantiate the fire particle system at the cannon's position
            ParticleSystem newFireParticles = Instantiate(cannonParticles, transform.position, Quaternion.LookRotation(Vector3.right));

            // Instantiate the smoke particle system as a child of the fire particles
            ParticleSystem newSmokeParticles = Instantiate(smokeParticles, newFireParticles.transform);

            // Destroy both fire and smoke particles after the specified lifetime
            Destroy(newFireParticles.gameObject, particleLifetime);
            Destroy(newSmokeParticles.gameObject, particleLifetime);
        }
    }
}

