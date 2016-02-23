using UnityEngine;
using System.Collections;

public class SkillCreateWall : Skill {
	public override void create(){
		name = "CreateWall";
		delay=5;
	}
	// Use this for initialization
	public override void playSkill(){
			createWall ();
	}

	public void createWall(){
		Wall wall = Wall.init (position);
	}
}