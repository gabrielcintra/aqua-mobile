﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Group
{
	public int id, owner_id;
	public string name;
	public List<User> members;

	public override string ToString()
	{
		return "id: " + id + "/ nome: " + name + " / owner_id:" + owner_id; 
	}
}
