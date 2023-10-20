using Archwyvern.Nxml;
using Godot;

namespace Archwyvern.Project;

public partial class Main : Node2D
{
    private SerializationManager.Initializer _initializer;

	public override void _Ready()
	{
        // The serializer takes a while to build, but runs in the background.
        // Once built, it doesn't need to do so again.
        SerializationManager.Initialize(LoadUI);
    }

    private void LoadUI(double loadTime) // or just LoadUI()
    {
        GD.Print("Serializer assembly time: " + loadTime); // ~1.95

        // Load your XML file and get the node layout from the serialization manager.
        // This process may soon include a custom resource to load with GD.Load<XNodeLayout>();

        var file = Godot.FileAccess.Open("res://data/Hud.nxml", Godot.FileAccess.ModeFlags.Read);
        var layout = SerializationManager.GetNodeLayout(file.GetAsText());

        double generateTime = Time.GetUnixTimeFromSystem();

        // The layout is a populated DTO containing all the raw data needed to create a node.
        var node = layout.Generate();

        GD.Print("Node generation time: " + (Time.GetUnixTimeFromSystem() - generateTime)); // ~0.008

        AddChild(node);
    }
}
