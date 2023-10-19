using Archwyvern.Nxml;
using Archwyvern.Nxml.Tags;
using Godot;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace Archwyvern.Project;

public partial class Main : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        var container = GetNode("PanelContainer/HFlowContainer");

        // TODO: abstract this all away, possible make a new resource type
        // GD.Load<Nxml>("res://data/Hud.Nxml");

        var file = FileAccess.Open("res://data/Hud.Nxml", FileAccess.ModeFlags.Read);
        var tag = SerializerManager.Deserialize(file.GetAsText());

        var node = tag.Generate<PanelContainer>();

        AddChild(node);

        GD.Load<XNodeLayout>("res://data/Hud.nxml");
    }
}
