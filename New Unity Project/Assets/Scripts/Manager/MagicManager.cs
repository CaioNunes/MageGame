using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicManager : MonoBehaviour {

    public GameObject fireball ;    
    public GameObject demonfire;
    public GameObject rockpunch;
    public GameObject rockwall;    
    public GameObject waterblade;
    public GameObject mirrorforce;

    public Hashtable magics;

	// Use this for initialization
	void Start () {
        magics = new Hashtable();
        magics.Add("FF", fireball);
        magics.Add("TT", rockpunch);
        magics.Add("AA", waterblade);
        magics.Add("AF", demonfire);
        magics.Add("FT", rockwall);
        magics.Add("AT", mirrorforce);
              
    }
	
	// Update is called once per frame
	void Update () {
        
    } 
}
