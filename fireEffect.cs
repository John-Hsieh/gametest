using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireEffect : MonoBehaviour
{
    public static fireEffect Instance;
    public ParticleSystem fire;
    public void Awake()
    {
        if (Instance != null) Debug.LogError("we got multiple special effect");

        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explosion(Vector3 position)
    {
        ParticleSystem newparticle = Instantiate(fire, position, Quaternion.identity);
        Destroy(newparticle.gameObject, 5);
    }
}
