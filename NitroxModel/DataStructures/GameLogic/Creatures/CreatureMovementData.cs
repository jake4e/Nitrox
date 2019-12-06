using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBufNet;
using UnityEngine;

namespace NitroxModel.DataStructures.GameLogic.Creatures
{
    [Serializable]
    [ProtoContract]
    public class CreatureMovementData
    {
        [ProtoMember(1)]
        public NitroxId Id { get; set; }

        [ProtoMember(2)]
        public Vector3 Position { get; }

        [ProtoMember(3)]
        public Quaternion Rotation { get; }

        [ProtoMember(4)]
        public Vector3 Velocity { get; }

        [ProtoMember(5)]
        public Vector3 AngularVelocity { get; }

        public CreatureMovementData()
        {

        }

        public CreatureMovementData(NitroxId id, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
        {
            Id = id;
            Position = position;
            Rotation = rotation;
            Velocity = velocity;
            AngularVelocity = angularVelocity;
        }
    }
}
