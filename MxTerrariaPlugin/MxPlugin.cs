using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace MxTerrariaPlugin;

[ApiVersion(2, 1)]
public class MxPlugin : TerrariaPlugin
{
    public override string Author => "Matheus Piccoli";
    public override string Description => "A simple plugin to give a OP kit to a Player.";
    public override string Name => "Mx Kit";
    public override Version Version => new Version(1, 0, 0, 0);
    
    public MxPlugin(Main game) : base(game)
    {
    }

    public override void Initialize()
    {
        Console.WriteLine("[MxPlugin] Plugin was initialized with success!");
        Commands.ChatCommands.Add(new Command("mx", MxCommand.Execute, "mx"));
    }

}