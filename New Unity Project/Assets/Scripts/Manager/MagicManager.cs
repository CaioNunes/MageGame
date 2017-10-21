using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicManager : MonoBehaviour {

    public GameObject fireball ;
    public GameObject fireshotgun;
    public GameObject demonfire;
    public GameObject rockpunch;
    public GameObject rockwall;
    public GameObject mudshot;
    public GameObject waterblade;
    public GameObject mirrorforce;
    public GameObject invisibility;
    public GameObject dispell;
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
        //magics.Add("ATT", mudshot);
        //magics.Add("FFT", fireshotgun); 
        //magics.Add("AAF", invisibility);
        //magics.Add("AFT", dispell);        
    }
	
	// Update is called once per frame
	void Update () {
        
    } 
}
