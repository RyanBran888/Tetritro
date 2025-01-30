using Godot;
using System;

public partial class Shop : Node2D
{
	//labels and button declaration thing
	private Label money;
	private Button cost1;
	private Button cost2;
	private Button cost3;
	private Button cost4;
	private Button nextRound;
	private Button reroll;
	private PopupPanel popup;
	private Node2D item1;
	private Node2D item2;
	private Node2D item3;
	private Node2D item4;
	private MenuButton sellMenu;
	//RNGGGGG
	private RandomNumberGenerator rand = new RandomNumberGenerator();
	//v a r i a b l e s
	private int itemSlot1 = -1;
	private int itemSlot2 = -1;
	private int itemSlot3 = -1;
	private int itemSlot4 = -1;
	private int itemSlot1Price = 0;
	private int itemSlot2Price = 0;
	private int itemSlot3Price = 0;
	private int itemSlot4Price = 0;
	//more things
	private Node2D purpleMultOb;
	private Node2D purpleSetOb;
	private Node2D blueMultOb;
	private Node2D blueSetOb;
	private Node2D yellowMultOb;
	private Node2D yellowSetOb;
	private Node2D redMultOb;
	private Node2D redSetOb;
	private Node2D greenMultOb;
	private Node2D greenSetOb;
	private Node2D darkBlueMultOb;
	private Node2D darkBlueSetOb;
	private Node2D orangeMultOb;
	private Node2D orangeSetOb;
	// c l o  n e
	private Node2D clone1;
	private Node2D clone2;
	private Node2D clone3;
	private Node2D clone4;
	// this should be up buyt im alxacyt
	private Node2D LockOb;
	private Node2D rowTop;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//uhhhh
		rowTop = GetNode<Node2D>("icons/other/rowTop");
		LockOb = GetNode<Node2D>("icons/other/HoldPiece");
		clone1 = null;
		clone2 = null;
		clone3 = null;
		clone4 = null;
		money = GetNode<Label>("Money");
		cost1 = GetNode<Button>("Cost1");
		cost2 = GetNode<Button>("Cost2");
		cost3 = GetNode<Button>("Cost3");
		cost4 = GetNode<Button>("Cost4");
		nextRound = GetNode<Button>("NextRound");
		reroll = GetNode<Button>("Reroll");
		popup = GetNode<PopupPanel>("PopupPanel");
		item1 = GetNode<Node2D>("Item1");
		item2 = GetNode<Node2D>("Item2");
		item3 = GetNode<Node2D>("Item3");
		item4 = GetNode<Node2D>("Item4");
		// thingy objects
		purpleMultOb = GetNode<Node2D>("icons/mult/PurpleMult");
		blueMultOb = GetNode<Node2D>("icons/mult/BlueMult");
		yellowMultOb = GetNode<Node2D>("icons/mult/YellowMult");
		redMultOb = GetNode<Node2D>("icons/mult/RedMult");
		greenMultOb = GetNode<Node2D>("icons/mult/GreenMult");
		darkBlueMultOb = GetNode<Node2D>("icons/mult/DarlBlueMult");
		orangeMultOb = GetNode<Node2D>("icons/mult/OrangeMult");
		purpleSetOb = GetNode<Node2D>("icons/set/PurpleSet");
		blueSetOb = GetNode<Node2D>("icons/set/BlueSet");
		yellowSetOb = GetNode<Node2D>("icons/set/YellowSet");
		redSetOb = GetNode<Node2D>("icons/set/RedSet");
		greenSetOb = GetNode<Node2D>("icons/set/GreenSet");
		darkBlueSetOb = GetNode<Node2D>("icons/set/DarkBlueSet");
		orangeSetOb = GetNode<Node2D>("icons/set/OrangeSet");
		sellMenu = GetNode<MenuButton>("SellMenu");
		//set money label to money
		money.Text = GameManager.Money.ToString();
		//Randomize();
	}
	//run frame every
	public override void _Process(double delta)
	{
		//set teh costs accordingly
		cost1.Text = itemSlot1Price.ToString();
		cost2.Text = itemSlot2Price.ToString();
		cost3.Text = itemSlot3Price.ToString();
		cost4.Text = itemSlot4Price.ToString();
		money.Text = GameManager.Money.ToString();
		//randomize when it enters to start the shop thingy in game
		if(clone1 == null && clone2 == null && clone3 == null && clone4 == null & !GameManager.running)
		{
			Randomize();
		}
		//give the photo for the shop item
		clone1.GlobalPosition = item1.GlobalPosition;
		clone2.GlobalPosition = item2.GlobalPosition;
		clone3.GlobalPosition = item3.GlobalPosition;
		clone4.GlobalPosition = item4.GlobalPosition;
	}
	//gives the itmes and their slots the thingy this cant be the easiest w2ay to code this
	private void Randomize()
	{
			int num = rand.RandiRange(0,15);
			(itemSlot1) = num;
			num = rand.RandiRange(0,15);
			(itemSlot2) = num;
			num = rand.RandiRange(0,15);
			(itemSlot3) = num;
			num = rand.RandiRange(0,15);
			(itemSlot4) = num;
		switch(itemSlot1)
		{
			case 0:
				//put tTime into slot 1
				itemSlot1Price = 4;
				clone1 = (Node2D)purpleSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 1:
				//put bluesclues into slot 1
				itemSlot1Price = 5;
				clone1 = (Node2D)blueSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 2:
				//yellow
				itemSlot1Price = 4;
				clone1 = (Node2D)yellowSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 3: 
				//red
				itemSlot1Price = 3;
				clone1 = (Node2D)redSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 4:
				//green
				itemSlot1Price = 3;
				clone1 = (Node2D)greenSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 5:
				//Darkblue
				itemSlot1Price = 4;
				clone1 = (Node2D)darkBlueSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 6: 
				//orange
				itemSlot1Price = 4;
				clone1 = (Node2D)orangeSetOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 7:
				//clear linething
				clone1 = (Node2D)rowTop.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				itemSlot1Price = 5;
				break;
			case 8:
				//purple mult
				itemSlot1Price = 7;
				clone1 = (Node2D)purpleMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 9: 
				//blue mult
				itemSlot1Price = 9;
				clone1 = (Node2D)blueMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 10:
				//blue mult
				itemSlot1Price = 7;
				clone1 = (Node2D)LockOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 11:
				//yellow mult
				itemSlot1Price = 7;
				clone1 = (Node2D)yellowMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 12:
				//redMult
				itemSlot1Price = 6;
				clone1 = (Node2D)redMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 13:
				//greenMult
				itemSlot1Price = 6;
				clone1 = (Node2D)greenMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 14:
				//darkblue mult
				itemSlot1Price = 7;
				clone1 = (Node2D)darkBlueMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
			case 15:
				//orange mult
				itemSlot1Price = 7;
				clone1 = (Node2D)orangeMultOb.Duplicate();
				AddChild(clone1);
				clone1.Scale = new Vector2(0.5f, 0.5f);
				clone1.Position = item1.Position;
				break;
		}
		switch(itemSlot2)
		{
			case 0:
				//put tTime into slot 1
				itemSlot2Price = 4;
				clone2 = (Node2D)purpleSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 1:
				//put bluesclues into slot 1
				itemSlot2Price = 5;
				clone2 = (Node2D)blueSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 2:
				//yellow
				itemSlot2Price = 4;
				clone2 = (Node2D)yellowSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 3: 
				//red
				itemSlot2Price = 3;
				clone2 = (Node2D)redSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 4:
				//green
				itemSlot2Price = 3;
				clone2 = (Node2D)greenSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 5:
				//Darkblue
				itemSlot2Price = 4;
				clone2 = (Node2D)darkBlueSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 6: 
				//orange
				itemSlot2Price = 4;
				clone2 = (Node2D)orangeSetOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 7:
				//clear linething
				itemSlot2Price = 5;
				clone2 = (Node2D)rowTop.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 8:
				//purple mult
				itemSlot2Price = 7;
				clone2 = (Node2D)purpleMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 9: 
				//blue mult
				itemSlot2Price = 9;
				clone2 = (Node2D)blueMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 10:
				//blue mult
				itemSlot2Price = 7;
				clone2 = (Node2D)LockOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				
				break;
			case 11:
				//yellow mult
				itemSlot2Price = 7;
				clone2 = (Node2D)yellowMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 12:
				//redMult
				itemSlot2Price = 6;
				clone2 = (Node2D)redMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 13:
				//greenMult
				itemSlot2Price = 6;
				clone2 = (Node2D)greenMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 14:
				//darkblue mult
				itemSlot2Price = 7;
				clone2 = (Node2D)darkBlueMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
			case 15:
				//orange mult
				itemSlot2Price = 7;
				clone2 = (Node2D)orangeMultOb.Duplicate();
				AddChild(clone2);
				clone2.Scale = new Vector2(0.5f, 0.5f);
				clone2.Position = item2.Position;
				break;
		}
		switch(itemSlot3)
		{
			case 0:
				//put tTime into slot 1
				itemSlot3Price = 4;
				clone3 = (Node2D)purpleSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 1:
				//put bluesclues into slot 1
				itemSlot3Price = 5;
				clone3 = (Node2D)blueSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 2:
				//yellow
				itemSlot3Price = 4;
				clone3 = (Node2D)yellowSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 3: 
				//red
				itemSlot3Price = 3;
				clone3 = (Node2D)redSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 4:
				//green
				itemSlot3Price = 3;
				clone3 = (Node2D)greenSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 5:
				//Darkblue
				itemSlot3Price = 4;
				clone3 = (Node2D)darkBlueSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 6: 
				//orange
				itemSlot3Price = 4;
				clone3 = (Node2D)orangeSetOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 7:
				//clear linething
				itemSlot3Price = 5;
				clone3 = (Node2D)rowTop.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 8:
				//purple mult
				itemSlot3Price = 7;
				clone3 = (Node2D)purpleMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 9: 
				//blue mult
				itemSlot3Price = 9;
				clone3 = (Node2D)blueMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 10:
				//blue mult
				itemSlot3Price = 7;
				clone3 = (Node2D)LockOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 11:
				//yellow mult
				itemSlot3Price = 7;
				clone3 = (Node2D)yellowMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 12:
				//redMult
				itemSlot3Price = 6;
				clone3 = (Node2D)redMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 13:
				//greenMult
				itemSlot3Price = 6;
				clone3 = (Node2D)greenMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 14:
				//darkblue mult
				itemSlot3Price = 7;
				clone3 = (Node2D)darkBlueMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
			case 15:
				//orange mult
				itemSlot3Price = 7;
				clone3 = (Node2D)orangeMultOb.Duplicate();
				AddChild(clone3);
				clone3.Scale = new Vector2(0.5f, 0.5f);
				clone3.Position = item3.Position;
				break;
		}
		switch(itemSlot4)
		{
			case 0:
				//put tTime into slot 1
				itemSlot4Price = 4;
				clone4 = (Node2D)purpleSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 1:
				//put bluesclues into slot 1
				itemSlot4Price = 5;
				clone4 = (Node2D)blueSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 2:
				//yellow
				itemSlot4Price = 4;
				clone4 = (Node2D)yellowSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 3: 
				//red
				itemSlot4Price = 3;
				clone4 = (Node2D)redSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 4:
				//green
				itemSlot4Price = 3;
				clone4 = (Node2D)greenSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 5:
				//Darkblue
				itemSlot4Price = 4;
				clone4 = (Node2D)darkBlueSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 6: 
				//orange
				itemSlot4Price = 4;
				clone4 = (Node2D)orangeSetOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 7:
				//clear linething
				itemSlot4Price = 5;
				clone4 = (Node2D)rowTop.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 8:
				//purple mult
				itemSlot4Price = 7;
				clone4 = (Node2D)purpleMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 9: 
				//blue mult
				itemSlot4Price = 9;
				clone4 = (Node2D)blueMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 10:
				//blue mult
				itemSlot4Price = 7;
				clone4 = (Node2D)LockOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 11:
				//yellow mult
				itemSlot4Price = 7;
				clone4 = (Node2D)yellowMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 12:
				//redMult
				itemSlot4Price = 6;
				clone4 = (Node2D)redMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 13:
				//greenMult
				itemSlot4Price = 6;
				clone4 = (Node2D)greenMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 14:
				//darkblue mult
				itemSlot4Price = 7;
				clone4 = (Node2D)darkBlueMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
			case 15:
				//orange mult
				itemSlot4Price = 7;
				clone4 = (Node2D)orangeMultOb.Duplicate();
				AddChild(clone4);
				clone4.Scale = new Vector2(0.5f, 0.5f);
				clone4.Position = item4.Position;
				break;
		}
	}
	// and the coipy and pasting begins here Gulp
	private void BuyOne()
	{
		switch(itemSlot1)
		{
			case 0:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.purpleSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.purpleSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.purpleSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.purpleSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 1:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.blueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.blueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.blueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.blueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 2:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.yellowSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.yellowSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.yellowSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.yellowSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 3: 
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.redSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.redSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.redSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.redSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 4:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.greenSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.greenSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.greenSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.greenSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 5:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.darkBlueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.darkBlueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.darkBlueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.darkBlueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 6: 
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.orangeSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.orangeSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.orangeSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.orangeSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 7:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.TopPop1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Efull)
					{
						GameManager.TopPop2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.TopPop3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot1Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.TopPop4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot1Price;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 8:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 9: 
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 10:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 11:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 12:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 13:
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 14:
				//darkblue mult
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot1 = -1;
					clone1.QueueFree();
				}
				break;
			case 15:
				//orange mult
				if(GameManager.Money >= itemSlot1Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot1Price;
						GameManager.eightFull = true;
					}
					itemSlot1 = -1;
					clone1.QueueFree();
					updateCash();
				}
				break;
		}
	}
	private void BuyTwo()
	{
		switch(itemSlot2)
		{
			case 0:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.purpleSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.purpleSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.purpleSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.purpleSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 1:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.blueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.blueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.blueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.blueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 2:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.yellowSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.yellowSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.yellowSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.yellowSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 3: 
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.redSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.redSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.redSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.redSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 4:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.greenSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.greenSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.greenSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.greenSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 5:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.darkBlueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.darkBlueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.darkBlueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.darkBlueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 6: 
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.orangeSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.orangeSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.orangeSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.orangeSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 7:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.TopPop1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Efull)
					{
						GameManager.TopPop2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.TopPop3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot2Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.TopPop4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot2Price;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 8:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 9: 
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 10:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 11:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 12:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 13:
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 14:
				//darkblue mult
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
			case 15:
				//orange mult
				if(GameManager.Money >= itemSlot2Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot2Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot2 = -1;
					clone2.QueueFree();
				}
				break;
		}
		
	}
	private void BuyThree()
	{
		switch(itemSlot3)
		{
			case 0:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.purpleSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.purpleSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.purpleSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.purpleSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 1:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.blueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.blueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.blueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.blueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 2:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.yellowSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.yellowSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.yellowSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.yellowSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 3: 
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.redSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.redSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.redSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.redSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 4:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.greenSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.greenSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.greenSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.greenSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 5:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.darkBlueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.darkBlueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.darkBlueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.darkBlueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 6: 
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.orangeSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.orangeSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.orangeSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.orangeSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 7:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.TopPop1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Efull)
					{
						GameManager.TopPop2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.TopPop3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot3Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.TopPop4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot3Price;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 8:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 9: 
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 10:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 11:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 12:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 13:
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 14:
				//darkblue mult
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
			case 15:
				//orange mult
				if(GameManager.Money >= itemSlot3Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot3Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot3 = -1;
					clone3.QueueFree();
				}
				break;
		}
		
	}
	private void BuyFour()
	{
		switch(itemSlot4)
		{
			case 0:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.purpleSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.purpleSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.purpleSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.purpleSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 1:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.blueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.blueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.blueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.blueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 2:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.yellowSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.yellowSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.yellowSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.yellowSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 3: 
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.redSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.redSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.redSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.redSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 4:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.greenSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.greenSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.greenSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.greenSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 5:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.darkBlueSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.darkBlueSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.darkBlueSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.darkBlueSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 6: 
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.orangeSet1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.orangeSet2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.orangeSet3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.orangeSet4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 7:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(GameManager.Qfull == false)
					{
						GameManager.TopPop1 = true;
						GameManager.Qfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Efull)
					{
						GameManager.TopPop2 = true;
						GameManager.Efull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Rfull)
					{
						GameManager.TopPop3 = true;
						GameManager.Rfull = true;
						GameManager.Money -= itemSlot4Price;
					}else if(!GameManager.Ffull)
					{
						GameManager.TopPop4 = true;
						GameManager.Ffull = true;
						GameManager.Money -= itemSlot4Price;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 8:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.purpleMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 9: 
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.blueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 10:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.hold = true;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 11:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.yellowMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 12:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.redMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 13:
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.greenMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 14:
				//darkblue mult
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.darkBlueMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
			case 15:
				//orange mult
				if(GameManager.Money >= itemSlot4Price)
				{
					if(!GameManager.oneFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.oneFull = true;
					}else if(!GameManager.twoFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.twoFull = true;
					}else if(!GameManager.threeFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.threeFull = true;
					}else if(!GameManager.fourFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fourFull = true;
					}else if(!GameManager.fiveFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.fiveFull = true;
					}else if(!GameManager.sixFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sixFull = true;
					}else if(!GameManager.sevenFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.sevenFull = true;
					}else if(!GameManager.eightFull)
					{
						GameManager.orangeMult += 1;
						GameManager.Money -= itemSlot4Price;
						GameManager.eightFull = true;
					}
					updateCash();
					itemSlot4 = -1;
					clone4.QueueFree();
				}
				break;
		}
		
	}
	//updates the cash
	private void updateCash()
	{
		money.Text = GameManager.Money.ToString();
	}
	//it rerols stuff....
	private void Reroll()
	{
		if(GameManager.Money >= 5)
		{
			Randomize();
			GameManager.Money -= 5;
			if(clone1 != null)
			{
				clone1.QueueFree();
			}
			if(clone2 != null)
			{
				clone2.QueueFree();
			}
			if(clone3 != null)
			{
				clone3.QueueFree();
			}
			if(clone4 != null)
			{
				clone4.QueueFree();
			}
		}
	}
	//stratasterardswr nbext wofurndsdr
	private void NextRound()
	{
		clone1 = null;
		clone2 = null;
		clone3 = null;
		clone4 = null;
		GameManager.numLeft = 20;
		GameManager.points = 0;
		GameManager.linesToClear = (int)Math.Round(GameManager.linesToClear*1.5);
		GameManager.running = true;
	}
}
