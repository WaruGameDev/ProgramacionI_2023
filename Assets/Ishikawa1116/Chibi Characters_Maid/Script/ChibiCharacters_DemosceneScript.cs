using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChibiCharacters_DemosceneScript : MonoBehaviour
{
	public Animator Anim;
	private Text AnimText;
    // Start is called before the first frame update
    void Start()
    {
		AnimText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		AnimText.text = Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name;
		Camera.main.orthographicSize = 1.25f - Screen.width / 1600f;
    }
}
