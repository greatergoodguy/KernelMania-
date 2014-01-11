using UnityEngine;
using System.Collections;

public class CtrlAudio : MonoBehaviour {

	AudioSource music;
	
	void Awake() {
		music = transform.FindChild_BB("Music").GetComponent_BB<AudioSource>();
	}
	
	public void MusicPlay() {
		music.Play();
	}
	
	public void MusicStop() {
		music.Stop();
	}
}
