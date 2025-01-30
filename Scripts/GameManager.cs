using Godot;
using System;
using Godot.Collections;
public partial class GameManager : Node2D
{
	private int r = 0;
	private Array<Node2D> placedBlocks = new Array<Node2D>();
	public delegate void BlockPlaced();
	public static int Money = 0;
	private Timer timer;
	private int x = 1;
	private bool addPoint = false;
	private int repeats = 0;
	private RandomNumberGenerator rand = new RandomNumberGenerator();
	public static int currentPiece = 0;
	public static Array<int> NextPieces = new Array<int>() {};
	private Node2D Active;
	private Node2D Purple;
	private Node2D Blue;
	private Node2D Yellow;
	private Node2D Red;
	private Node2D Green;
	private Node2D DarkBlue;
	private Node2D Orange;
	private bool placed = false;
	private const int GridWidth = 10;
	private const int GridHeight = 20;
	private int[,] grid = new int[GridWidth, GridHeight];
	private Vector2[] currentBlockPos;
	private const int CellSize = 40;
	private float fallSpeed = 1f;
	private Label moneyLabel;
	private Label clearLabel;
	private Label blockLeft;
	public static float points = 0;
	private Label pointsLabel;
	public static int linesToClear = 500;
	public static int numLeft = 20;
	public static int softPoint = 1;
	public static float singleMult = 1;
	public static float doubleMult = 1;
	public static float tripleMult = 1;
	public static float quadMult = 1;
	public static int moneyAdd = 0;
	public static int moneyMult = 1;
	public static int blockAdd = 0;
	public static float allMult = 1;
	public static int purpleAdd = 0;
	public static float purpleMult = 1;
	public static int blueAdd = 0;
	public static float blueMult = 1;
	public static int yellowAdd = 0;
	public static float yellowMult = 1;
	public static int redAdd = 0;
	public static float redMult = 1;
	public static int greenAdd = 0;
	public static float greenMult = 1;
	public static int darkBlueAdd = 0;
	public static float darkBlueMult = 1;
	public static int orangeAdd = 0;
	public static float orangeMult = 1;
	public static bool purpleExtra = false;
	public static bool blueExtra = false;
	public static bool yellowExtra = false;
	public static bool redExtra = false;
	public static bool greenExtra = false;
	public static bool darkBlueExtra = false;
	public static bool orangeExtra = false;
	public static bool Qfull = false;
	public static bool Efull = false;
	public static bool Rfull = false;
	public static bool Ffull = false;
	public static bool oneFull = false;
	public static bool twoFull = false;
	public static bool threeFull = false;
	public static bool fourFull = false;
	public static bool fiveFull = false;
	public static bool sixFull = false;
	public static bool sevenFull = false;
	public static bool eightFull = false;
	public static bool purpleSet1 = false;
	public static bool blueSet1 = false;
	public static bool yellowSet1 = false;
	public static bool redSet1 = false;
	public static bool greenSet1 = false;
	public static bool darkBlueSet1 = false;
	public static bool orangeSet1 = false;
	public static bool TopPop1 = false;
	public static bool purpleSet2 = false;
	public static bool blueSet2 = false;
	public static bool yellowSet2 = false;
	public static bool redSet2 = false;
	public static bool greenSet2 = false;
	public static bool darkBlueSet2 = false;
	public static bool orangeSet2 = false;
	public static bool TopPop2 = false;
	public static bool purpleSet3 = false;
	public static bool blueSet3 = false;
	public static bool yellowSet3 = false;
	public static bool redSet3 = false;
	public static bool greenSet3 = false;
	public static bool darkBlueSet3 = false;
	public static bool orangeSet3 = false;
	public static bool TopPop3 = false;
	public static bool purpleSet4 = false;
	public static bool blueSet4 = false;
	public static bool yellowSet4 = false;
	public static bool redSet4 = false;
	public static bool greenSet4 = false;
	public static bool darkBlueSet4 = false;
	public static bool orangeSet4 = false;
	public static bool TopPop4 = false;
	private int currentActive = 0;
	private int holding = 0;
	private Node2D HolderSpot;
	public static bool hold = false;
	private bool holdfast = false;
	public static bool purpleScale;
	public static bool blueScale;
	public static bool yellowScale;
	public static bool redScale;
	public static bool greenScale;
	public static bool darkBlueScale;
	public static bool orangeScale;
	public static bool singleScale;
	public static bool doubleScale;
	public static bool tripleScale;
	public static bool quadScale;
	public static bool moneyAddMult;
	public static bool running = true;
	private Camera2D camera;
	private Node2D purpleSetOb;
	private Node2D blueSetOb;
	private Node2D yellowSetOb;
	private Node2D redSetOb;
	private Node2D greenSetOb;
	private Node2D darkBlueSetOb;
	private Node2D orangeSetOb;
	private Node2D clone1;
	private Node2D clone2;
	private Node2D clone3;
	private Node2D clone4;
	private Node2D QSlot;
	private Node2D ESlot;
	private Node2D RSlot;
	private Node2D FSlot;
	private Node2D JSlotOne;
	private Node2D JSlotTwo;
	private Node2D JSlotThree;
	private Node2D JSlotFour;
	private Node2D JSlotFive;
	private Node2D JSlotSix;
	private Node2D JSlotSeven;
	private Node2D JSlotEight;
	private Node2D purpleMultOb;
	private Node2D blueMultOb;
	private Node2D yellowMultOb;
	private Node2D redMultOb;
	private Node2D greenMultOb;
	private Node2D darkBlueMultOb;
	private Node2D orangeMultOb;
	private Node2D HoldOb;
	private Node2D lineClearThingOb;
	private Node2D Jclone1;
	private Node2D Jclone2;
	private Node2D Jclone3;
	private Node2D Jclone4;
	private Node2D Jclone5;
	private Node2D Jclone6;
	private Node2D Jclone7;
	private Node2D Jclone8;
	public override void _Ready()
	{
		//For Future implemtatipon of showing currently purchased upgrades
		JSlotOne = GetNode<Node2D>("1");
		JSlotTwo = GetNode<Node2D>("2");
		JSlotThree = GetNode<Node2D>("3");
		JSlotFour = GetNode<Node2D>("4");
		JSlotFive = GetNode<Node2D>("5");
		JSlotSix = GetNode<Node2D>("6");
		JSlotSeven = GetNode<Node2D>("7");
		JSlotEight = GetNode<Node2D>("8");
		purpleMultOb = GetNode<Node2D>("icons/mult/PurpleMult");
		blueMultOb = GetNode<Node2D>("icons/mult/BlueMult");
		yellowMultOb = GetNode<Node2D>("icons/mult/YellowMult");
		redMultOb = GetNode<Node2D("icons/mult/RedMult");
		greenMultOb = GetNode<Node2D>("icons/mult/GreenMult");
		darkBlueMultOb = GetNode<Node2D>("icons/mult/DarkBlueMult");
		orangeMultOb = GetNode<Node2D>("icons/mult/OrangeMult");
		lineClearThingOb = GetNode<Node2D>("icons/other/rowTop");
		HoldOb = GetNode<Node2D>("icons/other/HoldPiece");
		purpleSetOb = GetNode<Node2D>("icons/set/PurpleSet");
		blueSetOb = GetNode<Node2D>("icons/set/BlueSet");
		yellowSetOb = GetNode<Node2D>("icons/set/YellowSet");
		redSetOb = GetNode<Node2D>("icons/set/RedSet");
		greenSetOb = GetNode<Node2D>("icons/set/GreenSet");
		darkBlueSetOb = GetNode<Node2D>("icons/set/DarkBlueSet");
		orangeSetOb = GetNode<Node2D>("icons/set/OrangeSet");
		
		points = 0;
		
		QSlot = GetNode<Node2D>("Q");
		ESlot = GetNode<Node2D>("E");
		RSlot = GetNode<Node2D>("R");
		FSlot = GetNode<Node2D>("F");
		
		//Neccesary Game Objects
		camera = GetNode<Camera2D>("Camera2D");
		camera.Position = new Vector2(960,540);
		
		HolderSpot = GetNode<Node2D>("PH3/Node");
		
		timer = GetNode<Timer>("Timer");
		
		//Blocks and their ndoes
		Purple = GetNode<Node2D>("Purple");
		Blue = GetNode<Node2D>("Blue");
		Yellow = GetNode<Node2D>("Yellow");
		Red = GetNode<Node2D>("Red");
		Green = GetNode<Node2D>("Green");
		DarkBlue = GetNode<Node2D>("DarkBlue");
		Orange = GetNode<Node2D>("Orange");
		
		//Labels
		moneyLabel = GetNode<Label>("moneyLabel");
		clearLabel = GetNode<Label>("PH/pointsLabel");
		pointsLabel = GetNode<Label>("clearLabel");
		blockLeft = GetNode<Label>("PH2/blockLeft");
		
		//code to start the game
		GenerateNextPieces();
		SpawnNextBlock();
		timer.Start(fallSpeed);
		
		//set the labels
		moneyLabel.Text = "$" + Money;
		clearLabel.Text = linesToClear.ToString();
		
		//set the block amount
		numLeft = 20;
	}
	//Run every frame
	public override void _Process(double delta)
	{
		//set the labels to ensure they are correct
		clearLabel.Text = linesToClear.ToString();
		pointsLabel.Text = points.ToString();
		blockLeft.Text = numLeft.ToString(); 
		
		//end the rounds
		if(numLeft <= 0)
		{
			if(points >= linesToClear)
			{
				running = false;
			}else
			{
				
				GetTree().ChangeSceneToFile("res://GameOver.tscn");
			}
		}
		// open the shop when round is over
		if(!running)
		{
			camera.Position = new Vector2(-2040, -2459);
		}else
		{
			camera.Position = new Vector2(960,540);
			
		}
		//for future implementation
		/*if(oneFull && !twoFull)
		{
			if(hold)
			{
				Jclone1 = purpleMultOb.Duplicate();
				AddChild(Jclone1);
				Jclone1.Scale = new Vector2(0.5, 0.5);
				Jclone1.GlobalPosition = JSlotOne.GlobalPosition;
			}
			}if(purpleMult == 2)
			{
				Jclone1 = purpleMultOb.Duplicate();
				AddChild(Jclone1);
				Jclone1.Scale = new Vector2(0.5, 0.5);
				Jclone1.GlobalPosition = JSlotOne.GlobalPosition;
			}
		}else if(twoFull && !threeFull)
		{
			
		}else if(threeFull && !fourFull)
		{
			
		}else if(fourFull && !fiveFull)
		{
			
		}else if(fiveFull && !sixFull)
		{
			
		}else if(sixFull && !sevenFull)
		{
			
		}else if(sevenFull && !eightFull)
		{
			
		}else if(eightFull)
		{
			
		}
		*/
		//Show the current one time use upgrades
		if(purpleSet2)
		{
			clone2 = (Node2D)purpleSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(blueSet2)
		{
			clone2 = (Node2D)blueSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(yellowSet2)
		{
			clone2 = (Node2D)yellowSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(redSet2)
		{
			clone2 = (Node2D)redSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(greenSet2)
		{
			clone2 = (Node2D)greenSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(darkBlueSet2)
		{
			clone2 = (Node2D)darkBlueSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(orangeSet2)
		{
			clone2 = (Node2D)orangeSetOb.Duplicate();
			AddChild(clone2);
			clone2.GlobalPosition = ESlot.GlobalPosition;
		}
		if(purpleSet1)
		{
			clone1 = (Node2D)purpleSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(blueSet1)
		{
			clone1 = (Node2D)blueSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(yellowSet1)
		{
			clone1 = (Node2D)yellowSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(redSet1)
		{
			clone1 = (Node2D)redSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(greenSet1)
		{
			clone1 = (Node2D)greenSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(darkBlueSet1)
		{
			clone1 = (Node2D)darkBlueSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(orangeSet1)
		{
			clone1 = (Node2D)orangeSetOb.Duplicate();
			AddChild(clone1);
			clone1.GlobalPosition = QSlot.GlobalPosition;
		}
		if(purpleSet3)
		{
			clone3 = (Node2D)purpleSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(blueSet3)
		{
			clone3 = (Node2D)blueSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(yellowSet3)
		{
			clone3 = (Node2D)yellowSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(redSet3)
		{
			clone3 = (Node2D)redSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(greenSet3)
		{
			clone3 = (Node2D)greenSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(darkBlueSet3)
		{
			clone3 = (Node2D)darkBlueSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(orangeSet3)
		{
			clone3 = (Node2D)orangeSetOb.Duplicate();
			AddChild(clone3);
			clone3.GlobalPosition = RSlot.GlobalPosition;
		}
		if(purpleSet4)
		{
			clone4 = (Node2D)purpleSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(blueSet4)
		{
			clone4 = (Node2D)blueSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(yellowSet4)
		{
			clone4 = (Node2D)yellowSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(redSet4)
		{
			clone4 = (Node2D)redSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(greenSet4)
		{
			clone4 = (Node2D)greenSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(darkBlueSet4)
		{
			clone4 = (Node2D)darkBlueSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
		if(orangeSet4)
		{
			clone4 = (Node2D)orangeSetOb.Duplicate();
			AddChild(clone4);
			clone4.GlobalPosition = FSlot.GlobalPosition;
		}
	}
	//caluclate any bonuses for purple blocks
	private void PurpleClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += purpleAdd * purpleMult;
		}
		if(purpleScale)
		{
			purpleMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for blue blocks
	private void BlueClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += blueAdd * blueMult;
		}
		if(blueScale)
		{
			blueMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for yellow blocks
	private void YellowClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += yellowAdd * yellowMult;
		}
		if(yellowScale)
		{
			yellowMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for red blocks
	private void RedClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += redAdd * redMult;
		}
		if(redScale)
		{
			redMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for green blocks
	private void GreenClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += greenAdd * greenMult;
		}
		if(greenScale)
		{
			greenMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for dark blue blocks
	private void DarkBlueClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += darkBlueAdd * darkBlueMult;
		}
		if(darkBlueScale)
		{
			darkBlueMult += (0.1f*num);
		}
	}
	//caluclate any bonuses for orange blocks
	private void OrangeClear(int num)
	{
		for(int i = num; i > 0; i--)
		{
		points += orangeAdd * orangeMult;
		}
		if(orangeScale)
		{
			orangeMult += (0.1f*num);
		}
	}
	//adds the T block to the queue, a lot of times (for the one time power)
	private void TTime()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 1;
		}
		UpdateNextPieceDisplay();
	}
	//adds the blue block to the queue, a lot of times (for the one time power)
	private void BluesQueues()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 2;
		}
		UpdateNextPieceDisplay();
	}
	//adds the yellow block to the queue, a lot of times (for the one time power)
	private void SlowDown()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 3;
		}
		UpdateNextPieceDisplay();
	}
	//adds the red block to the queue, a lot of times (for the one time power)
	private void Stop()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 4;
		}
		UpdateNextPieceDisplay();
	}
	//adds the green block to the queue, a lot of times (for the one time power)
	private void GO()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 5;
		}
		UpdateNextPieceDisplay();
	}
	//adds the J (dark blue) block to the queue, a lot of times (for the one time power)
	private void FlockOfJays()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 6;
		}
		UpdateNextPieceDisplay();
	}
	//adds the orange block to the queue, a lot of times (for the one time power)
	private void CitrusCity()
	{
		for(int i = 0; i < 5; i++)
		{
			NextPieces[i] = 7;
		}
		UpdateNextPieceDisplay();
	}
	//adds extra blocks for this round (not yet implemented) (for the one time power)
	private void AddExtraBlocks()
	{
		numLeft += 5;
	}
	//clears the top row (can be changed to clear the top Number rows) (for the one time power)
	private void topPop(int Number)
	{
		Array<int> row = new Array<int>();
		for(int i = 0; i < 20; i++)
		{
			if(GetTree().GetNodesInGroup(i.ToString()).Count >= 1)
			{
				row.Add((i-1));
				
				if(row.Count == Number)
					break;
			}
		}
		ClearLines(row);
	}
	// old update vlaue system idk
	private void valueUpdate()
	{
		moneyLabel.Text = "$" + Money;
	}
	//run when the timer runs out
	private void Timeout()
	{
		addPoint = false;
		//move the block down one space
		MoveBlock(Vector2.Down);
	}
	//check to see if any lines are full when a new block is placed
	private void CheckLineClearLine()
	{
		if(running)
		{
		Array<int> fullRows = new Array<int>();
		//count the amount of each color
		int purple = 0;
		int blue = 0;
		int yellow = 0;
		int red = 0;
		int green = 0;
		int darkBlue = 0;
		int orange = 0;
		for(int y = 0; y < GridHeight; y++)
		{
			bool isFull = true;
			for(int x = 0; x < GridWidth; x++)
			{
				if(grid[x,y] == 0)
				{
				isFull = false;
				break;
				}
			}
			Array<Node> groups = GetTree().GetNodesInGroup(y.ToString());
		if(isFull)
		{	//add to the values
			foreach(Node node in groups)
			{
				if(node.IsInGroup("Purple"))
				{
					purple++;
				}
				if(node.IsInGroup("Blue"))
				{
					blue++;
				}
				if(node.IsInGroup("Yellow"))
				{
					yellow++;
				}
				if(node.IsInGroup("Red"))
				{
					red++;
				}
				if(node.IsInGroup("Green"))
				{
					green++;
				}
				if(node.IsInGroup("DarkBlue"))
				{
					darkBlue++;
				}
				if(node.IsInGroup("Orange"))
				{
					orange++;
				}
			}
			fullRows.Add(y);
		}
		}
		//if a line is full, run the clear lines and the colorClear functions
		if(fullRows.Count > 0)
		{
			ClearLines(fullRows);
			PurpleClear(purple);
			BlueClear(blue);
			YellowClear(yellow);
			RedClear(red);
			GreenClear(green);
			DarkBlueClear(darkBlue);
			OrangeClear(orange);
		}
	}
	}
	//clear the lines when a line is full
	private void ClearLines(Array<int> rowsToClear)
	{
		int lines = rowsToClear.Count;
		//calculate the points for the amount of lines
		switch(lines)
		{
			case 1:
				if(singleScale)
					singleMult += 0.1f;
				points += 100 * singleMult * allMult;
				break;
			case 2:
				if(doubleScale)
					doubleMult += 0.1f;
				points += 300 * doubleMult * allMult;
				break;
			case 3:
				if(tripleScale)
					tripleMult += 0.1f;
				points += 500 * tripleMult * allMult;
				break;
			case 4:
				if(quadScale)
					quadMult += 0.1f;
				points += 800 * quadMult * allMult;
				break;
		}
		//calculate money
		if(rowsToClear.Count != 4)
		{
			Money += (rowsToClear.Count + moneyAdd) * moneyMult;
		}else if(rowsToClear.Count == 4)
		{
			Money += (8 + moneyAdd) * moneyMult;
		}
		//get them into reverse order
		rowsToClear.Sort();
		rowsToClear.Reverse();
		foreach(int row in rowsToClear)
		{
			for(int x = 0; x < GridWidth; x++)
			{
				grid[x, row] = 0;
				Array<Node> groups = GetTree().GetNodesInGroup((row + 1).ToString());
				foreach(Node node in groups)
				{
					node.QueueFree();
				}
				
			}
		}
		//i forgot what i was debugging here but it was something maybe wait i remember it sends the htingy to the next function for the thingy
		for(int i = rowsToClear.Count - 1; i > -1; i--)
		{
			GD.Print(rowsToClear[i]);
			MoveDown(rowsToClear[i], rowsToClear.Count - 1);
			break;
		}
		}
		//moves down the blocks after the line below is cleared (this took me hours)
	private void MoveDown(int row, int nums)
	{
			for(int y = (row + 1); y > 0; y--)
			{
				Array<Node> groups = GetTree().GetNodesInGroup((y - 1).ToString());
				foreach(Node node in groups)
				{
					for(int z = 1; z <= 10; z++)
					{
						if(grid[z-1, y-2] != 1) continue;
							grid[z-1, y-2] = 0;
							if(GetNode<Node2D>($"R{y+nums}/C{z}") == null) continue;
							Vector2 CellPos = GetNode<Node2D>($"R{y+nums}/C{z}").GlobalPosition;
								if(node is Node2D node2D)
								{
									grid[z-1, (y+nums) -1] = 1;
									node2D.GlobalPosition = new Vector2(node2D.GlobalPosition.X, CellPos.Y);
									node2D.RemoveFromGroup((y-1).ToString());
									node2D.AddToGroup((y+nums).ToString());
									GD.Print(node2D.GlobalPosition.Y);
									GD.Print(node2D + " " + CellPos.Y + "\n");
									CellPos = new Vector2(0, 0);
									break;
								}
					}
				}
				}
				GD.Print("RAWR");
			valueUpdate();
			//prints the grid out or wtv
			for(int y = 0; y < GridHeight; y++)
	{
		string pow = "";
		for(int x = 0; x < GridWidth; x++)
		{
			pow += grid[x, y] + " ";
		}
		GD.Print(pow);
	}

	}
	//idk i call this thing sometimes to duplicate the things
	private Node2D GetBlockInstance(int pieceId)
	{
		switch(pieceId)
		{
			case 1: return (Node2D)Purple.Duplicate();
			case 2: return (Node2D)Blue.Duplicate();
			case 3: return (Node2D)Yellow.Duplicate();
			case 4: return (Node2D)Red.Duplicate();
			case 5: return (Node2D)Green.Duplicate();
			case 6: return (Node2D)DarkBlue.Duplicate();
			case 7: return (Node2D)Orange.Duplicate();
			default: return null;
		}
	}
	// update sthe next pieces thing
	private void UpdateNextPieceDisplay()
	{
		var nextContainer = GetNode<Node>("NextPieces");
		for(int i = 0; i < NextPieces.Count; i++)
		{
			var nextPieceNode = nextContainer.GetChild<Node2D>(i);
			if(nextPieceNode != null)
			{
				foreach(var child in nextPieceNode.GetChildren())
				{
					child.QueueFree();
				}
				Node2D nextPieceInstance = GetBlockInstance(NextPieces[i]);
				nextPieceNode.AddChild(nextPieceInstance);
				nextPieceInstance.Position = new Vector2(0, 0);
				nextPieceInstance.Scale = new Vector2(0.75f, 0.75f);
			}
		}
	}
	//erm rotates the block... obviously
	private void RotateBlock(bool clockwise)
	{
		Vector2 pivot = currentBlockPos[0];
		Vector2[] rotatedPos = new Vector2[currentBlockPos.Length];
		for(int i = 0; i < currentBlockPos.Length; i++)
		{
			Vector2 relative = currentBlockPos[i] - pivot;
			if(clockwise)
			{
				rotatedPos[i] = new Vector2(
					pivot.X - relative.Y,
					pivot.Y + relative.X
				);
			}else
			{
				rotatedPos[i] = new Vector2(
					pivot.X + relative.Y,
					pivot.Y - relative.X
				);
			}
			if(CanMoveTo(rotatedPos, Vector2.Zero))
			{
				currentBlockPos = rotatedPos;
				UpdateBlockPos();
			}
		}
	}
	//adds more to queue so queue is full :3
	private void GenerateNextPieces()
	{
		if(running)
		{
		rand.Randomize();
		for(int i = 0; i < 4; i++)
		{
			int pieceChosen = rand.RandiRange(1, 7);
			NextPieces.Add(pieceChosen);
		}
		UpdateNextPieceDisplay();
		}
	}
	//spawn next block duh
	private void SpawnNextBlock()
	{
		if(NextPieces.Count == 0);
		{
			GenerateNextPieces();
		}
		int pieceChosen = NextPieces[0];
		currentPiece = NextPieces[0];
		NextPieces.RemoveAt(0);
		UpdateNextPieceDisplay();
		//stupid long code for stupid long statement
		switch(pieceChosen)
		{
			case 1://purple :3
				Active = (Node2D)Purple.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Purple");
				}
				currentBlockPos = new Vector2[] { new Vector2(5,1), new Vector2(4, 2), new Vector2(5, 2), new Vector2(6, 2)};
				break;
			case 2: //Light Blue :3
				Active = (Node2D)Blue.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Blue");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(6, 1), new Vector2(7, 1), new Vector2(8, 1) };
				break;
			case 3: //yellow
				Active = (Node2D)Yellow.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Yellow");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(6, 1), new Vector2(5, 2), new Vector2(6, 2)};
				break;
			case 4: //red
				Active = (Node2D)Red.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Red");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(6, 1), new Vector2(6, 2), new Vector2(7,2)};
				break;
			case 5: //green
				Active = (Node2D)Green.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Green");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(4, 1), new Vector2(4, 2), new Vector2(3,2)};
				break;
			case 6:// Dark Blue
				Active = (Node2D)DarkBlue.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("DarkBlue");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(6, 1), new Vector2(7, 1), new Vector2(5, 2)};
				break;
			case 7:// orange >:3
				Active = (Node2D)Orange.Duplicate();
				AddChild(Active);
				for(int i = 0; i < 4; i++)
				{
					Active.GetChild(i).AddToGroup("Orange");
				}
				currentBlockPos = new Vector2[] { new Vector2(5, 1), new Vector2(6, 1), new Vector2(7, 1), new Vector2(7, 2)};
				break;
			}
			UpdateBlockPos();
		}
		//updates the active block to match the grid system
	private void UpdateBlockPos()
	{
		for(int i = 0; i < currentBlockPos.Length; i++)
		{
			int row = (int)currentBlockPos[i].Y;
			int column = (int)currentBlockPos[i].X;
			var cell = GetNode<Node2D>($"R{row}/C{column}");
			if(cell  == null) continue;
				Vector2 globalCellPos = cell.ToGlobal(Vector2.Zero);
				Node2D childBlock = Active.GetChild(i) as Node2D;
			if(childBlock == null) continue;
				childBlock.GlobalPosition = globalCellPos;
		}
	}
	//checks if it can mvoe to the place
	private bool CanMoveTo(Vector2[] blockPos, Vector2 direction)
	{
		foreach (var pos in blockPos)
		{
			int x = (int)(pos.X + direction.X);
			int y = (int)(pos.Y + direction.Y);
			//GD.Print($"Checking position: ({x}, {y})");
			if(x < 1 || y > GridHeight || y < 1 || x > GridWidth)
				return false;
			if(IsCellTaken(x, y))
				return false;
		}
		return true;
	}
	//i forgor whyu i need this i think this checks the htingy that the other thing checks
	private bool IsCellTaken(int column, int row)
	{
		if(row < 1 || row > GridHeight || column < 1 || column > GridWidth)
			return true;
		
		return grid[column -1, row - 1] != 0;
	}
	//it moves the block....
	private void MoveBlock(Vector2 direction)
	{
		if(running)
		{
		if(CanMoveTo(currentBlockPos, direction))
		{
			for(int i = 0; i < currentBlockPos.Length; i++)
			{
				currentBlockPos[i] += direction;
				if(addPoint)
				{
				points += softPoint;
				}
			}
			if(addPoint)
			{
				points -= (softPoint*3);
			}
			UpdateBlockPos();
			//places if its going down and cant
		}else if(direction == Vector2.Down)
		{
			PlaceBlock(currentBlockPos);
		}
		}
	}
	//places the block
	private bool PlaceBlock(Vector2[] blockPos)
	{
		r = 0;
		foreach (var pos in blockPos)
		{
			int x = (int)pos.X;
			int y = (int)pos.Y;
			grid[x - 1, y - 1] = 1;
			var child = Active.GetChild(r);
			if(child != null)
			{
				//add to group for clearing stuff
				child.AddToGroup(GetBlockRow(r));
			//	GD.Print(r);
			}
			r++;
		}
		//not yet implemented power ups
		if(Active.GetChild(1).IsInGroup("Purple") && purpleExtra == true)
		{
			NextPieces[3] = 1;
		}
		if(Active.GetChild(1).IsInGroup("Blue") && blueExtra == true)
		{
			NextPieces[3] = 2;
		}
		if(Active.GetChild(1).IsInGroup("Yellow") && yellowExtra == true)
		{
			NextPieces[3] = 3;
		}
		if(Active.GetChild(1).IsInGroup("Red") && redExtra == true)
		{
			NextPieces[3] = 4;
		}
		if(Active.GetChild(1).IsInGroup("Green") && greenExtra == true)
		{
			NextPieces[3] = 5;
		}
		if(Active.GetChild(1).IsInGroup("DarkBlue") && darkBlueExtra == true)
		{
			NextPieces[3] = 6;
		}
		if(Active.GetChild(1).IsInGroup("Orange") && orangeExtra == true)
		{
			NextPieces[3] = 7;
		}
		//variables!!!!
		holdfast = false;
		numLeft--;
		EmitSignal(nameof(BlockPlaced));
		CheckLineClearLine();
		SpawnNextBlock();
		return true;
	}
	//for the group thing
	private string GetBlockRow(int childNum)
	{
		Vector2 gridPos = currentBlockPos[childNum];
		int row = (int)gridPos.Y;
		return (row).ToString();
	}
	//checks the inpuits for the stuff
	public override void _Input(InputEvent @event)
	{
		if(running)
		{
		if(@event is InputEventKey keyEvent)
		{
			//rotates left
			if(keyEvent.Pressed && keyEvent.Keycode == Key.Left)
			{
				RotateBlock(false);
			}
			//rotates left
			if(keyEvent.Pressed && keyEvent.Keycode == Key.Right)
			{//aaahahahahahahah wakatime testing did i fix it does it work idk i gotta type so it can check the things for the stuff and the things
				RotateBlock(true);
			}//AHy9gdwfuyr3wefgyuiwrfguy8wrfguriy8ygu WHY DOESNT ANYTTHING WORTK FIRST MY COMPUTER STOPS WORKING SO I MISS THE SATURDAY, I GET THE COMPUTER FIXED AND NOW THE WAKATIME DOESNT WORK AND I CANT CODE IM NOT GONNA BE ABLE TO GET THE 3D PRINTER WHAT DO I DO I CANT DO THIS 
			if(keyEvent.Pressed && keyEvent.Keycode == Key.D)
			{		
			//	pressing the D button moves you right? no for some reaosn my code flipped the right and left but it works and idc
					MoveBlock(Vector2.Right);
			}
			if(keyEvent.Pressed && keyEvent.Keycode == Key.A)
			{
				//same thing as above go read my yap sesh
					MoveBlock(Vector2.Left);
			}
			// do w n
			if(keyEvent.Pressed && keyEvent.Keycode == Key.S)
			{
					MoveBlock(Vector2.Down);
					addPoint = true;
			}
			//power up things!
			if(keyEvent.Pressed && keyEvent.Keycode == Key.Q)
			{
				if(purpleSet1 == true)
				{
					TTime();
					purpleSet1 = false;
					clone1.QueueFree();
				}else if(blueSet1)
				{
					BluesQueues();
					blueSet1 = false;
					clone1.QueueFree();
				}else if(yellowSet1)
				{
					SlowDown();
					yellowSet1 = false;
					clone1.QueueFree();
				}else if(redSet1)
				{
					Stop();
					redSet1 = false;
					clone1.QueueFree();
					
				}else if(greenSet1)
				{
					GO();
					greenSet1 = false;
					clone1.QueueFree();
				}else if(darkBlueSet1)
				{
					FlockOfJays();
					darkBlueSet1 = false;
					clone1.QueueFree();
				}else if(orangeSet1)
				{
					CitrusCity();
					orangeSet1 = false;
					clone1.QueueFree();
				}else if(TopPop1)
				{
					topPop(1);
					TopPop1 = false;
				}
			}
			//power up row 2!!!!
			if(keyEvent.Pressed && keyEvent.Keycode == Key.R)
			{
				if(purpleSet2 == true)
				{
					TTime();
					purpleSet2 = false;
					clone2.QueueFree();
				}else if(blueSet2)
				{
					BluesQueues();
					blueSet1 = false;
					clone2.QueueFree();
				}else if(yellowSet2)
				{
					SlowDown();
					yellowSet2 = false;
					clone2.QueueFree();
				}else if(redSet2)
				{
					Stop();
					redSet2 = false;
					clone2.QueueFree();
					
				}else if(greenSet2)
				{
					GO();
					greenSet2 = false;
					clone2.QueueFree();
				}else if(darkBlueSet2)
				{
					FlockOfJays();
					darkBlueSet2 = false;
					clone2.QueueFree();
				}else if(orangeSet2)
				{
					CitrusCity();
					orangeSet2 = false;
					clone2.QueueFree();
				}else if(TopPop2)
				{
					topPop(1);
					TopPop2 = false;
					
				}
			}
			//row 3
			if(keyEvent.Pressed && keyEvent.Keycode == Key.R)
			{
				if(purpleSet3 == true)
				{
					TTime();
					purpleSet3 = false;
					clone3.QueueFree();
				}else if(blueSet3)
				{
					BluesQueues();
					blueSet3 = false;
					clone3.QueueFree();
				}else if(yellowSet3)
				{
					SlowDown();
					yellowSet3 = false;
					clone3.QueueFree();
				}else if(redSet3)
				{
					Stop();
					redSet3 = false;
					clone3.QueueFree();
					
				}else if(greenSet3)
				{
					GO();
					greenSet3 = false;
					clone3.QueueFree();
				}else if(darkBlueSet3)
				{
					FlockOfJays();
					darkBlueSet3 = false;
					clone3.QueueFree();
				}else if(orangeSet3)
				{
					CitrusCity();
					orangeSet3 = false;
					clone3.QueueFree();
				}else if(TopPop3)
				{
					topPop(1);
					TopPop3 = false;
					clone3.QueueFree();
				}
			}
			//4
			if(keyEvent.Pressed && keyEvent.Keycode == Key.F)
			{
				if(purpleSet4 == true)
				{
					TTime();
					purpleSet4 = false;
					clone4.QueueFree();
				}else if(blueSet4)
				{
					BluesQueues();
					blueSet4 = false;
					clone4.QueueFree();
				}else if(yellowSet4)
				{
					SlowDown();
					yellowSet4 = false;
					clone4.QueueFree();
				}else if(redSet4)
				{
					Stop();
					redSet4 = false;
					clone4.QueueFree();
				}else if(greenSet4)
				{
					GO();
					greenSet4 = false;
					clone4.QueueFree();
				}else if(darkBlueSet4)
				{
					FlockOfJays();
					darkBlueSet4 = false;
					clone4.QueueFree();
				}else if(orangeSet4)
				{
					CitrusCity();
					orangeSet4 = false;
					clone4.QueueFree();
				}else if(TopPop4)
				{
					topPop(1);
					TopPop4 = false;
				}
			}
			//swaps the holded item thing
			if(keyEvent.Pressed && keyEvent.Keycode == Key.Space && hold && !holdfast)
			{
				swapHeld();
			}
		}
		}
	}	//actually swapes the hoded thing
		private void swapHeld()
		{
			//first item held?
			if(holding == 0)
			{
				holdfast = true;
				holding = currentPiece;
				Active.QueueFree();
				Node2D holds = GetBlockInstance(currentPiece);
				HolderSpot.AddChild(holds);
				holds.Scale = new Vector2(0.5f, 0.5f);
				holds.Position = new Vector2(0,0);
				SpawnNextBlock();
			}else//its not.. ok run this then
			{
				holdfast = true;
				NextPieces.Insert(0, holding);
				holding = currentPiece;
				Active.QueueFree();
				HolderSpot.GetChild(0).QueueFree();
				Node2D holds = GetBlockInstance(holding);
				HolderSpot.AddChild(holds);
				GD.Print(holds);
				holds.Scale = new Vector2(0.5f, 0.5f);
				holds.Position = new Vector2(0,0);
				SpawnNextBlock();
			}
		}
		//thanks for reading :3
	}
