using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCredits : MonoBehaviour {
    float speed = 0.1f;
    bool crawling = false;
    

    // Use this for initialization
    void Start () {
        
        var tc = this.GetComponent<GUIText>();
        var creds = "Command Line\n";
        creds += "\n";
        creds += "\n";
        creds += "Brought to you by:\n";
        creds += "\n";
        creds += "GGJ Organizer / Taco Man\nJeremy Callinan\n";
        creds += "\nProject Lead?\nEvan Griffin\n";
        creds += "\nHead Artist, Background Artist,\n Character Designer\nGabe \"Gabe \" Gomez\n";
        creds += "\nBackup Artist, Character Designer,\n Sprite animator,\n Dab Animation Expert\nMalik Rivers\n";
        creds += "\nBackup artist, voice actor,\n destroyer of ronald mcdonald\nJulian \"The Crab\" Rowe\n";
        creds += "\nSound Finder\nVoice Actor\nAustin Waltenbaugh\n";
        creds += "\nOriginal Music Score\nTyler Calkins\n";
        creds += "\nOriginal Music Score\nAlan Hancock\n";
        creds += "\nCamera/Coder\nDanny Buringrud\n";
        creds += "\nDesign Lead\n Code, Moral Support\nJames Crescenzi\n";
        creds += "\nNon-Moral Support\n\n\n for Greg Mckibbin\nGreg McKibbin\n";
        creds += "\nNightshift Programmer\nTyler Griffith\n";
        creds += "\nNightshift Programmer\nRyan Filas\n";
        creds += "\nNightshift Programmer\nMatt Young\n";
        crawling = true;
        tc.text = creds;
    }
	
	// Update is called once per frame
	void Update () {
        if (!crawling)
            return;
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (this.gameObject.transform.position.y > 8)
        {
            crawling = false;
        }
    }
}
