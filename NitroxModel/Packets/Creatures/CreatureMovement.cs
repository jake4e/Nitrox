using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NitroxModel.DataStructures.GameLogic.Creatures;
using NitroxModel.Networking;

namespace NitroxModel.Packets.Creatures
{
    [Serializable]
    public class CreatureMovement : Movement
    {
        public CreatureMovementData Creature { get; }

        public CreatureMovement(ushort creatureId, CreatureMovementData creature) : base(creatureId, creature.Position, creature.Velocity, creature.Rotation, creature.Rotation)
        {
            Creature = creature;
            DeliveryMethod = NitroxDeliveryMethod.DeliveryMethod.UnreliableSequenced;
            UdpChannel = UdpChannelId.CREATURE_MOVEMENT;
        }

        public override string ToString()
        {
            return "[CreatureMovement - creature: " + Creature + "]\n\t" + base.ToString();
        }
    }
}
