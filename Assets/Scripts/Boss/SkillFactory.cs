using UnityEngine;
using System.Collections;

public class SkillFactory{
//	Skill skill;
	// Ham tao skill
	// tao thoi gian delay sau moi lan dung skill duoc dinh nghia
	// trong moi lop con cua  lop Skill
	Skill skill;
	public Skill getSkill(string skillType){
		if (skill == null) {
			Debug.Log("Kien");
		}
		GameObject skillObj = new GameObject ("skill");
		if(skillType.Equals("CreateWall"))
			skill= skillObj.AddComponent <SkillCreateWall>() as SkillCreateWall;
		else if (skillType.Equals("SubmerseRise"))
			skill= skillObj.AddComponent <SkillSubmerseRise>() as SkillSubmerseRise;
		else if (skillType.Equals("GunHit"))
			skill= skillObj.AddComponent <SkillGunHit>() as SkillGunHit;
		skill.create ();
		return skill;
	}
	public static SkillFactory init(){
//		GameObject sfObj = new GameObject ("sfObj");
//		return sfObj.AddComponent <SkillFactory>() as SkillFactory;
		return new SkillFactory ();
	}
}