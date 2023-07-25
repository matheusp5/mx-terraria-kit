using Terraria.ID;
using TShockAPI;

namespace MxTerrariaPlugin;

public class MxCommand
{
    public static void Execute(CommandArgs args)
    {
        TSPlayer player = args.Player;
        GivePlayerItem(ItemID.TrueNightsEdge, player);
        GivePlayerItem(ItemID.Picksaw, player);
        GivePlayerItem(ItemID.SpectreHamaxe, player);
        
        GivePlayerItem(ItemID.Tsunami, player);
        player.GiveItem(ItemID.IchorArrow, 999, 1);

        player.GiveItem(ItemID.Wood, 999, 1);

        GivePlayerItem(ItemID.StardustHelmet, player);
        GivePlayerItem(ItemID.StardustBreastplate, player);
        GivePlayerItem(ItemID.StardustLeggings, player);
        GivePlayerItem(ItemID.WingsNebula, player);
    }

    private static void GivePlayerItem(int type, TSPlayer player)
    {
        player.GiveItem(type, 1, 1);
    }
}