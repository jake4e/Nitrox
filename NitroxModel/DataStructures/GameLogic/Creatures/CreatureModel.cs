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
    public class CreatureModel
    {
        [ProtoMember(1)]
        public NitroxId Id { get; set; }

        [ProtoMember(2)]
        public Vector3 Position { get; set; }

        [ProtoMember(3)]
        public Quaternion Rotation { get; set; }

        public CreatureModel()
        {

        }

        public CreatureModel(NitroxId id, Vector3 position, Quaternion rotation)
        {
            Id = id;
            Position = position;
            Rotation = rotation;
        }
    }
}
