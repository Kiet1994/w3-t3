using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


	[CreateAssetMenu(fileName = "ItemData", menuName = "GameConfiguration/ItemData", order = 1)]
	public class ItemData : ScriptableObject
	{
		public string Name;
		public Sprite imgItem;
		public int quantity; // khong nen luu vao vi ScriptableObject de luu cac gia tri khong doi
		
	}
