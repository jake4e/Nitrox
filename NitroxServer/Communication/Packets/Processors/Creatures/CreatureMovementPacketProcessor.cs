using NitroxModel.Packets;
using NitroxModel.Packets.Creatures;
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
            throw new System.NotImplementedException();
        }
    }
}
