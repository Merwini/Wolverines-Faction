using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using CombatExtended;
using UnityEngine;

namespace rep.factions.wolverines
{
	public class DamageWorker_SelfDestruct : DamageWorker
	{
		public override DamageResult Apply(DamageInfo dinfo, Thing victim)
		{
			DamageResult result = base.Apply(dinfo, victim);
			Thing kamikaze = dinfo.Instigator;
			IntVec3 c = kamikaze.Position;
			ThingDef projectileDef = dinfo.Def.explosionCellMote;

			var projectile = (ProjectileCE)ThingMaker.MakeThing(projectileDef);
			projectile.Launch(
				launcher: kamikaze,
				origin: new Vector2(c.x, c.z)
				);

			kamikaze.Kill();

			return result;
		}
	}
}
