//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CombatExtended;
//using RimWorld;
//using Verse;
//using Verse.Sound;
//using UnityEngine;

//namespace rep.factions.blackwave
//{
//    class ProjectileCE_ArbitraryDistance : ProjectileCE
//    {
//        private float distance;

//        public override void Launch(Thing launcher, Vector2 origin, float shotAngle, float shotRotation, float shotHeight = 0f, float shotSpeed = -1f, Thing equipment = null, float distance = -1)
//        {
//            this.shotHeight = shotHeight;
//            this.shotAngle = SelectShotAngle(shotHeight);
//            this.shotRotation = shotRotation;
//            this.distance = distance < 0 ? def.projectile.speed : distance;
//            this.shotSpeed = shotSpeed;
//            if (def.projectile is ProjectilePropertiesCE props)
//            {
//                this.castShadow = props.castShadow;
//                this.lerpPosition = props.lerpPosition;
//                //this.GravityFactor = props.Gravity; //TODO CE has this set to private, fix this later
//                this.shotSpeed = CalculateRequiredSpeed(this.distance, shotHeight, this.shotAngle, props.Gravity);
//            }
//            Log.Message("Shot height: " + this.shotHeight.ToString());
//            Log.Message("Shot angle: " + this.shotAngle.ToString());
//            Log.Message("Shot speed: " + this.shotSpeed.ToString());
//            Log.Message("Shot distance: " + this.distance.ToString());
//            Launch(launcher, origin, equipment);
//        }

//        public override void Launch(Thing launcher, Vector2 origin, Thing equipment = null)
//        {
//            this.launcher = launcher;
//            this.origin = origin;
//            this.OriginIV3 = new IntVec3(origin);
//            this.Destination = origin + Vector2.up.RotatedBy(shotRotation) * distance;
//            Log.Message("Destination cell: " + this.Destination.ToString());
//            this.equipment = equipment;
//            //For explosives/bullets, equipmentDef is important
//            equipmentDef = (equipment != null) ? equipment.def : null;

//            if (!def.projectile.soundAmbient.NullOrUndefined())
//            {
//                var info = SoundInfo.InMap(this, MaintenanceType.PerTick);
//                ambientSustainer = def.projectile.soundAmbient.TrySpawnSustainer(info);
//            }
//            this.startingTicksToImpact = GetFlightTime() * GenTicks.TicksPerRealSecond;
//            this.ticksToImpact = Mathf.CeilToInt(this.startingTicksToImpact);
//            this.ExactPosition = this.LastPos = new Vector3(origin.x, shotHeight, origin.y);
//        }

//        public static float SelectShotAngle(float shotHeight)
//        {
//            float shotAngle;

//            if (shotHeight < 0.001f)
//            {
//                shotAngle = 45.0f * Mathf.Deg2Rad;
//            }
//            else
//            {
//                shotAngle = 0f;
//            }

//            return shotAngle;
//        }

//        public static float CalculateRequiredSpeed(float intendedRange, float shotHeight, float shotAngle, float gravityFactor)
//        {
//            //return Mathf.Sqrt(intendedRange * gravityFactor / Mathf.Sin(2f * shotAngle));
            
//            return Mathf.Sqrt((intendedRange * gravityFactor / Mathf.Exp()        ) + ())





//        }
//    }
//}
