﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Substrate.Entities
{
    using Substrate.Nbt;

    public class EntityPigZombie : EntityMob
    {
        public static readonly SchemaNodeCompound PigZombieSchema = MobSchema.MergeInto(new SchemaNodeCompound("")
        {
            new SchemaNodeString("id", "PigZombie"),
        });

        public EntityPigZombie ()
            : base("PigZombie")
        {
        }

        public EntityPigZombie (EntityTyped e)
            : base(e)
        {
        }


        #region INBTObject<Entity> Members

        public override bool ValidateTree (TagNode tree)
        {
            return new NbtVerifier(tree, PigZombieSchema).Verify();
        }

        #endregion


        #region ICopyable<Entity> Members

        public override EntityTyped Copy ()
        {
            return new EntityPigZombie(this);
        }

        #endregion
    }
}
