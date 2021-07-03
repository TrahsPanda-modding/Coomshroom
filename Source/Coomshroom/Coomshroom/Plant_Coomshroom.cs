using System.Text;
using RimWorld;
using UnityEngine;
using Verse;

namespace Coomshroom
{
    public class Plant_Coomshroom : Plant
    {
        protected override bool Resting => false;
        public override float GrowthRate
        {
            get
            {
                if (base.Blighted)
                {
                    return 0f;
                }
                if (base.Spawned && !PlantUtility.GrowthSeasonNow(base.Position, base.Map))
                {
                    return 0.1f;
                }
                return base.GrowthRateFactor_Fertility * base.GrowthRateFactor_Temperature;
            }
        }
    }
}