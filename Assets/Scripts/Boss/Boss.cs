using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public abstract class Boss : Enemy
{
	public Skill skill;
	public int maxHp;
	public string[] skillType = new string[3];
	public GameObject bossObj;

	public float calculateHpPercent ()
	{
		return (float)(healthy / maxHp * 100);
	}
	// de tao 1 con boss thi can co so luong mau lon nhat va ten 3 skill cua no    
	public void create (int maxHp, int speed,string skillType1,string skillType2,string skillType3  ,string prefabName)
	{
		bossObj = NewObjectFromPrefab (prefabName, new Vector2 (0, 0));
		this.maxHp = maxHp;
		healthy = maxHp;
		this.speed = speed;
		skillType [0] = skillType1;
		skillType [1] = skillType2;
		skillType [2] = skillType3;
	}

	// 100%->70% mau thi dung skill type1 trong mang skillType
	// 70% -> 40% mau thi dung skill type2 trong mang skillType
	// duoi 40% mau thi dung skill type3 trong mang skillType
	public void skillManager ()
	{
		float percentHeath = calculateHpPercent ();
		if (percentHeath >= 70.0) {
			if (skill == null)
				skill = SkillFactory.init ().getSkill (skillType [0]);
		} else if (percentHeath < 70.0 && percentHeath >= 40.0) {
			if (!skill.name.Equals (skillType[1]))
				skill = SkillFactory.init ().getSkill (skillType [1]);
		} else if (percentHeath < 40.0 && percentHeath > 40.0) {
			if (!skill.name.Equals (skillType [2]))
				skill = SkillFactory.init ().getSkill (skillType [2]);            
		}
	}

	public static GameObject NewObjectFromPrefab (string prefabName, Vector2 position)
	{
		Object prefab = AssetDatabase.LoadAssetAtPath ("Assets/Prefabs/" + prefabName + ".prefab", typeof(GameObject));
		return Instantiate (prefab, position, Quaternion.identity) as GameObject;
	}

	public abstract void bossUpdate ();
}
