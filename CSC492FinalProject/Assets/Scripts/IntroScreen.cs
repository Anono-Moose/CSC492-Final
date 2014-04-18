using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class IntroScreen : MonoBehaviour 
{
	private string title = "METAL MAN";
	private string newgame = "New Game";
	private string loadgame = "Load Game";
	private string instructions = "How to Play";
	private string highscore = "High Score";

	
	public Rect backgroundPos = new Rect (0,0,1024,768);
	
	private Rect titlePos   = new Rect (350,50,200,100);
	private Rect newGamePos = new Rect (150,150,200,50);
	private Rect loadGamePos = new Rect (150,250,200,50);
	private Rect instructionPos = new Rect (150,350,200,50);
	private Rect highscorePos = new Rect (150,450,200,50);
	private Rect infoBoxPos = new Rect(400, 150, 450, 450);
	
	public GUISkin introMenu; 
	
	public Texture2D background = null;
	public Texture2D startButtonImage;

	private bool isVisible = false;

	void OnGUI()
	{
		GUI.skin = introMenu;

		GUI.DrawTexture (backgroundPos, background);

		GUI.Label (titlePos, title, "title");

		if (GUI.Button (newGamePos, newgame)) 
		{
			isVisible = true;
			print ("clicked on newgame");
		}

		else if(GUI.Button (loadGamePos, loadgame))
		{
			print ("clicked on loadgame");
		}

		else if(GUI.Button (instructionPos, instructions))
		{
			print ("clicked on instructions");
		}

		else if(GUI.Button (highscorePos, highscore))
		{
			print ("clicked on instructions");
		}

		if(isVisible == true)
		{
			GUI.Box(infoBoxPos, "MENU");
		}
	}
}
