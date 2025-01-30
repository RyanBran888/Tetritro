using Godot;
using System;

public partial class Node2d : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	//you dont need help with this.... right...
	private void Press()
	{
		GetTree().ChangeSceneToFile("res://MainTetris.tscn");
	}
}
