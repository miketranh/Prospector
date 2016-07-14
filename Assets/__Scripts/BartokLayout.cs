using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//The SlotDef class is not a subclass of MonoBehaviour, so it doesn't need a separate C# file.
[System.Serializable]
public class SlotDef{
	public float x;
	public float y;
	public bool faceUp = false;
	public string layerName = "Default";
	public int layerID = 0;
	public int id;
	public List<int> hiddenBy = new List<int>();
	public float rot;
	public string type="slot";
	public Vector2 stagger;
	public int player;
	public Vector3 pos;
}


public class BartokLayout : MonoBehaviour {
	public PT_XMLReader xmlr;
	public PT_XMLHashtable xml;
	public Vector2 multiplier;
	tableau
		public List<SlotDef> slotDefs;
	public SlotDef drawPile;
	public SlotDef discardPile;
	public SlotDef target;
	public void ReadLayout(string xmlText){
		xmlr = new PT_XMLReader ();
		xmlr.Parse (xmlText);
		xml = xmlr.xml ["xml"] [0];
		multiplier.x= float.Parse(xml["multiplier"][0].att("x"))
		multiplier.y = float.Parse (xml ["multiplier"] [0].att ("y"));
		
		SlotDef tSD;
		PT_XMLHashList slotsX = xml ["slot"];
		
		for (int i=0; i<slotsX.Count; i++) {
			tSD = new SlotDef();
			if(slotsX[i].HasAtt("type")){
				tSD.type = slotsX[i].att("type");
			} else {
				tSD.type = "slot";
			}
			tSD.x = float.Parse (slotsX[i].att("x"));
			tSD.y = float.Parse (slotsX[i].att("y"));
			tSD.pos = new Vector3(tSD.x*multiplier.x,tSD.y*multiplier.y,0)
				//sorting Layers
			tSD.layerID = int.Parse (slotsX[i].att("layer"));
			
			tSD.layerName = tSD.layerID.ToString();
			
			switch (tSD.type){
			case "slot":
				break;
			case "drawpile":
				s
				break;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
