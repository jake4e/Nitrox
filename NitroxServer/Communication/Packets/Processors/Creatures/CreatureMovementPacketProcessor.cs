using System;
using System.Collections.Generic;
using NitroxModel.Logger;
using NitroxModel.Packets;
using NitroxServer.Communication.Packets.Processors.Abstract;
using NitroxServer.GameLogic;
using NitroxServer.GameLogic.Creatures;

namespace NitroxServer.Communication.Packets.Processors.Creatures
{
    class CreatureMovementPacketProcessor : AuthenticatedPacketProcessor<CreatureMovement>
    {
        private readonly CreatureData creatureData;
        private readonly PlayerManager playerManager;

        public CreatureMovementPacketProcessor(PlayerManager playerManager, CreatureData creatureData)
        {
            this.playerManager = playerManager;
            this.creatureData = creatureData;
        }

        public override void Process(CreatureMovement packet, Player player)
        {
            Log.Debug("Using creature packet processor for: " + packet.ToString() + " and player " + player.Id);
            playerManager.SendPacketToOtherPlayers(packet, player);
        }
    }
}
