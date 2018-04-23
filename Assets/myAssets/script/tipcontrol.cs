using UnityEngine;
using System.Collections;

public class tipcontrol : MonoBehaviour {
    public GameObject text;
    public AudioClip doordefine;

    void OnTriggerEnter(Collider col) {
      //  GameObject.Find("First Person Controller").GetComponent<pickcell>().pickedCell >= 4
        if (col.gameObject.tag == "player" && pickcell.pickedCell>=4)
        {
            transform.FindChild("door").SendMessage("openDoor");
            Destroy(text);
        }
        else if(col.gameObject.tag == "player" && pickcell.pickedCell <= 4)
        {
            text.guiText.text = "filed";
            audio.PlayOneShot(doordefine);
        }
    }

}
