using System.Collections.Generic;
using NitroxModel.DataStructures;
using NitroxModel.DataStructures.GameLogic.Creatures;
using NitroxModel.DataStructures.Util;
using ProtoBufNet;

namespace NitroxServer.GameLogic.Creatures
{
    [ProtoContract]
    public class CreatureData
    {
        [ProtoIgnore]
        private Dictionary<NitroxId, CreatureModel> creaturesById = new Dictionary<NitroxId, CreatureModel>();

        [ProtoMember(1)]
        public Dictionary<NitroxId, CreatureModel> SerializableCreaturesById
        {
            get
            {
                lock (creaturesById)
                {
                    return new Dictionary<NitroxId, CreatureModel>(creaturesById);
                }
            }
            set { creaturesById = value; }
        }

        public void UpdateCreature(CreatureMovementData creatureMovement)
        {
            lock (creaturesById)
            {
                if (creaturesById.ContainsKey(creatureMovement.Id))
                {
                    creaturesById[creatureMovement.Id].Position = creatureMovement.Position;
                    creaturesById[creatureMovement.Id].Rotation = creatureMovement.Rotation;
                }
            }
        }

        public List<CreatureModel> GetCreaturesForInitialSync()
        {
            lock (creaturesById)
            {
                return new List<CreatureModel>(creaturesById.Values);
            }
        }

        public Optional<CreatureModel> GetCreatureModel(NitroxId id)
        {
            lock (creaturesById)
            {
                CreatureModel creatureModel;

                if(creaturesById.TryGetValue(id, out creatureModel))
                {
                    return Optional<CreatureModel>.OfNullable(creatureModel);
                }
                else
                {
                    return Optional<CreatureModel>.Empty();
                }
            }
        }

        public Optional<T> GetCreatureModel<T>(NitroxId id) where T : CreatureModel
        {
            lock (creaturesById)
            {
                CreatureModel creatureModel;

                if(creaturesById.TryGetValue(id, out creatureModel) && creatureModel is T)
                {
                    return Optional<T>.OfNullable((T)creatureModel);
                }
                else
                {
                    return Optional<T>.Empty();
                }
            }
        }
    }
}
