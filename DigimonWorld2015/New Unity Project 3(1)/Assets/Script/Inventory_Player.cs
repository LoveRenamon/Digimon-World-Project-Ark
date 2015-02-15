﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory_Player : MonoBehaviour {
	public List<GameObject> Slots = new List<GameObject> ();
	public List<Item> Items = new List<Item> ();
	ItemDatabase database;
	public GameObject slots;
	int x = -24;
	int y =141;
	public int enableItem = 0;


	// Use this for initialization
	void Start () {
		int Slotamount = 0;
		database = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent<ItemDatabase> ();

		for (int i =0; i <5; i++) {
						GameObject slot = (GameObject)Instantiate (slots);
						slot.GetComponent<SlotScript>().SlotNum = Slotamount;
						Slots.Add (slot);
						Items.Add(new Item());
						slot.name = "Button";
						slot.transform.parent = this.gameObject.transform;
						slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
						slot.transform.localScale = new Vector3 (1,1,1);
						y -= 70;
						Slotamount++;
				}
		//addItem (1);



		//Debug.Log (Items [1].name);
	}
	
	// Update is called once per frame
	void Update () {

//		switch (enableItem) 
//		{
//
//		case 1:
//			for(int i =0;i<Slots.Count;i++)
//			{
//				if(Items[i].name== "Hawk Radish")
//				{
//					enableItem = 0;
//					Debug.Log("WTF");
//					break;
//				}
//			} 
//			addItem (0);
//			Debug.Log(enableItem+"BITCH");
//			enableItem = 0;
//			break;
//		case 2:
//			for(int i =0;i<Slots.Count;i++)
//			{
//				if(Items[i].name== "Meat")
//				{
//					enableItem = 0;
//					Debug.Log("WTF");
//					break;
//				}
//			}
//			addItem(1);
//			enableItem = 0;
//			break;
//		}
		//Debug.Log (GameObject.Find ("Itemdatabase").GetComponent<ItemDatabase> ()._items[1].amount);
	}

	public void addItem(int id)
	{
		for (int i =0; i< database._items.Count; i++) 
		{
			if (database._items[i].id == id)
			{
				Item item = database._items[i];
				addItemAtEmptySlot(item);
				break;
			}
		}
	}

	void addItemAtEmptySlot(Item item)
	{
		for (int i =0; i<Items.Count; i++) 
		{
			if (Items[i].name == null)
			{
				Items[i] = item;
				break;
			}
		}
	}
}
