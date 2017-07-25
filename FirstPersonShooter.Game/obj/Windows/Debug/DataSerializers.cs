
using System;
using System.Collections.Generic;
using System.Reflection;
using SiliconStudio.Core.Serialization;
using SiliconStudio.Core.Reflection;
using SiliconStudio.Core.Serialization.Serializers;
using SiliconStudio.DataSerializers;

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETPortable,Version=v5.0", FrameworkDisplayName=".NET Portable Subset")]

[assembly: SiliconStudio.Core.Serialization.Serializers.AssemblySerializerFactory(Type = typeof(SiliconStudio.DataSerializers.FirstPersonShooter_GameSerializerFactory))]

namespace SiliconStudio.Core.Serialization.Serializers
{
	class AssemblySerializerFactoryAttribute : Attribute
	{
		public Type Type;
	}
}

namespace SiliconStudio.DataSerializers
{
    // Assembly attributes that defines supported serializer (only generics one so that other assemblies can do generic instantiations by themselves)
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooter_TriggerScriptSerializer), typeof(FirstPersonShooter.TriggerScript), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterTrigger_TriggerGroupSerializer), typeof(FirstPersonShooter.Trigger.TriggerGroup), DataSerializerGenericMode.None, false, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<FirstPersonShooter.Trigger.TriggerEvent>), typeof(System.Collections.Generic.List<FirstPersonShooter.Trigger.TriggerEvent>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterTrigger_TriggerEventSerializer), typeof(FirstPersonShooter.Trigger.TriggerEvent), DataSerializerGenericMode.None, false, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooter_EffectControllerSerializer), typeof(FirstPersonShooter.EffectController), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooter_FpsCameraSerializer), typeof(FirstPersonShooter.FpsCamera), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_AnimationControllerSerializer), typeof(FirstPersonShooter.Player.AnimationController), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_PlayerControllerSerializer), typeof(FirstPersonShooter.Player.PlayerController), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_PlayerInputSerializer), typeof(FirstPersonShooter.Player.PlayerInput), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<SiliconStudio.Xenko.Input.Keys>), typeof(System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.EnumSerializer<SiliconStudio.Xenko.Input.Keys>), typeof(SiliconStudio.Xenko.Input.Keys), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_WeaponScriptSerializer), typeof(FirstPersonShooter.Player.WeaponScript), DataSerializerGenericMode.None, true, true, Profile = "Default")]
   	public static class FirstPersonShooter_GameSerializerFactory
	{
	    [SiliconStudio.Core.ModuleInitializer(-1000)]
        internal static void Initialize()
        {
			var assemblySerializers = new AssemblySerializers(typeof(FirstPersonShooter_GameSerializerFactory).GetTypeInfo().Assembly);

			// Register data contract aliases
			assemblySerializers.DataContractAliases.Add(new AssemblySerializers.DataContractAlias(@"TriggerEvent", typeof(FirstPersonShooter.Trigger.TriggerEvent), false));
			assemblySerializers.DataContractAliases.Add(new AssemblySerializers.DataContractAlias(@"TriggerGroup", typeof(FirstPersonShooter.Trigger.TriggerGroup), false));

			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_EngineSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_PhysicsSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Core_MathematicsSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_CoreSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_ParticlesSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_SpriteStudio_RuntimeSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_NativeSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_UISerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_NavigationSerializerFactory).GetTypeInfo().Module);

			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Default"] = assemblySerializersProfile;

				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xae01e935, 0x03f8d36e, 0x968f6f46, 0xc57deba3), typeof(FirstPersonShooter.TriggerScript), typeof(SiliconStudio.DataSerializers.FirstPersonShooter_TriggerScriptSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x7375122a, 0x16575c62, 0x4c8de9ab, 0x6315baf8), typeof(FirstPersonShooter.Trigger.TriggerGroup), typeof(SiliconStudio.DataSerializers.FirstPersonShooterTrigger_TriggerGroupSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x8158df44, 0x355f7f76, 0xe1c62af9, 0xe4521b14), typeof(System.Collections.Generic.List<FirstPersonShooter.Trigger.TriggerEvent>), typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<FirstPersonShooter.Trigger.TriggerEvent>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xc62fc48c, 0x4bfc49fd, 0xc70a679e, 0x41b36258), typeof(FirstPersonShooter.Trigger.TriggerEvent), typeof(SiliconStudio.DataSerializers.FirstPersonShooterTrigger_TriggerEventSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x6ad76ffc, 0xe9ffde37, 0x0342db43, 0x38f92519), typeof(FirstPersonShooter.EffectController), typeof(SiliconStudio.DataSerializers.FirstPersonShooter_EffectControllerSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x5b7c9a54, 0x93ea5776, 0x65c50b6b, 0xfdd19209), typeof(FirstPersonShooter.FpsCamera), typeof(SiliconStudio.DataSerializers.FirstPersonShooter_FpsCameraSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x32d2507a, 0x1577b959, 0x30615ef3, 0x52637d2b), typeof(FirstPersonShooter.Player.AnimationController), typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_AnimationControllerSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x0d9ade83, 0x547de61b, 0xa0db2eb0, 0xeecc299f), typeof(FirstPersonShooter.Player.PlayerController), typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_PlayerControllerSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x3fe90b90, 0x5eeaf06a, 0xc96efd0c, 0xe20ff8a3), typeof(FirstPersonShooter.Player.PlayerInput), typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_PlayerInputSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xd4040867, 0xf10f81e8, 0x8b793bd8, 0xfd612480), typeof(System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>), typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<SiliconStudio.Xenko.Input.Keys>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x3b55a4c0, 0x93225d33, 0xe5593eaa, 0xf80dbca0), typeof(SiliconStudio.Xenko.Input.Keys), typeof(SiliconStudio.Core.Serialization.Serializers.EnumSerializer<SiliconStudio.Xenko.Input.Keys>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x03f3b984, 0x224e147f, 0x43fde923, 0x0ce06983), typeof(FirstPersonShooter.Player.WeaponScript), typeof(SiliconStudio.DataSerializers.FirstPersonShooterPlayer_WeaponScriptSerializer)));
			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Content"] = assemblySerializersProfile;

			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Hash"] = assemblySerializersProfile;

			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Clone"] = assemblySerializersProfile;

			}

			DataSerializerFactory.RegisterSerializationAssembly(assemblySerializers);
            AssemblyRegistry.Register(typeof(FirstPersonShooter_GameSerializerFactory).GetTypeInfo().Assembly, AssemblyCommonCategories.Engine);
        }
	}
}



namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooter_TriggerScriptSerializer : DataSerializer<FirstPersonShooter.TriggerScript>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<FirstPersonShooter.Trigger.TriggerGroup> TriggerGroupSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			TriggerGroupSerializer = MemberSerializer<FirstPersonShooter.Trigger.TriggerGroup>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.TriggerScript obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.TriggerScript)parentObj;

            FirstPersonShooter.Trigger.TriggerGroup triggerGroup = mode == ArchiveMode.Serialize ? obj.TriggerGroup : default(FirstPersonShooter.Trigger.TriggerGroup);
            TriggerGroupSerializer.Serialize(ref triggerGroup, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.TriggerGroup = triggerGroup;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterTrigger_TriggerGroupSerializer : ClassDataSerializer<FirstPersonShooter.Trigger.TriggerGroup>
	{
		private DataSerializer<System.String> NameSerializer;
		private DataSerializer<System.Collections.Generic.List<FirstPersonShooter.Trigger.TriggerEvent>> TriggerEventsSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Cache member serializers
			NameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			TriggerEventsSerializer = MemberSerializer<System.Collections.Generic.List<FirstPersonShooter.Trigger.TriggerEvent>>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Trigger.TriggerGroup obj, ArchiveMode mode, SerializationStream stream)
		{
            System.String name = mode == ArchiveMode.Serialize ? obj.Name : default(System.String);
            NameSerializer.Serialize(ref name, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Name = name;
            System.Collections.Generic.List<FirstPersonShooter.Trigger.TriggerEvent> triggerEvents = obj.TriggerEvents;
            TriggerEventsSerializer.Serialize(ref triggerEvents, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterTrigger_TriggerEventSerializer : ClassDataSerializer<FirstPersonShooter.Trigger.TriggerEvent>
	{
		private DataSerializer<System.String> NameSerializer;
		private DataSerializer<SiliconStudio.Xenko.Engine.Prefab> SourcePrefabSerializer;
		private DataSerializer<System.Boolean> FollowEntitySerializer;
		private DataSerializer<System.Single> DurationSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector3> PositionSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Quaternion> RotationSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector3> ScaleSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Cache member serializers
			NameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			SourcePrefabSerializer = MemberSerializer<SiliconStudio.Xenko.Engine.Prefab>.Create(serializerSelector);
			FollowEntitySerializer = MemberSerializer<System.Boolean>.Create(serializerSelector);
			DurationSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
			PositionSerializer = MemberSerializer<SiliconStudio.Core.Mathematics.Vector3>.Create(serializerSelector);
			RotationSerializer = MemberSerializer<SiliconStudio.Core.Mathematics.Quaternion>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Trigger.TriggerEvent obj, ArchiveMode mode, SerializationStream stream)
		{
            System.String name = mode == ArchiveMode.Serialize ? obj.Name : default(System.String);
            NameSerializer.Serialize(ref name, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Name = name;
            SiliconStudio.Xenko.Engine.Prefab sourcePrefab = mode == ArchiveMode.Serialize ? obj.SourcePrefab : default(SiliconStudio.Xenko.Engine.Prefab);
            SourcePrefabSerializer.Serialize(ref sourcePrefab, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.SourcePrefab = sourcePrefab;
            System.Boolean followEntity = mode == ArchiveMode.Serialize ? obj.FollowEntity : default(System.Boolean);
            FollowEntitySerializer.Serialize(ref followEntity, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.FollowEntity = followEntity;
            System.Single duration = mode == ArchiveMode.Serialize ? obj.Duration : default(System.Single);
            DurationSerializer.Serialize(ref duration, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Duration = duration;
            SiliconStudio.Core.Mathematics.Vector3 position = mode == ArchiveMode.Serialize ? obj.Position : default(SiliconStudio.Core.Mathematics.Vector3);
            PositionSerializer.Serialize(ref position, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Position = position;
            SiliconStudio.Core.Mathematics.Quaternion rotation = mode == ArchiveMode.Serialize ? obj.Rotation : default(SiliconStudio.Core.Mathematics.Quaternion);
            RotationSerializer.Serialize(ref rotation, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Rotation = rotation;
            SiliconStudio.Core.Mathematics.Vector3 scale = mode == ArchiveMode.Serialize ? obj.Scale : default(SiliconStudio.Core.Mathematics.Vector3);
            PositionSerializer.Serialize(ref scale, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Scale = scale;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooter_EffectControllerSerializer : ClassDataSerializer<FirstPersonShooter.EffectController>
	{
		private DataSerializer<FirstPersonShooter.TriggerScript> parentSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<FirstPersonShooter.TriggerScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"FirstPersonShooter.TriggerScript"));
			// Cache member serializers
		}

		public override void Serialize(ref FirstPersonShooter.EffectController obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			FirstPersonShooter.TriggerScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.EffectController)parentObj;

		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooter_FpsCameraSerializer : ClassDataSerializer<FirstPersonShooter.FpsCamera>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.Single> RotationSpeedSerializer;
		private DataSerializer<System.Single> RotationAdaptationSpeedSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			RotationSpeedSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.FpsCamera obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.FpsCamera)parentObj;

            System.Single rotationSpeed = mode == ArchiveMode.Serialize ? obj.RotationSpeed : default(System.Single);
            RotationSpeedSerializer.Serialize(ref rotationSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.RotationSpeed = rotationSpeed;
            System.Single rotationAdaptationSpeed = mode == ArchiveMode.Serialize ? obj.RotationAdaptationSpeed : default(System.Single);
            RotationSpeedSerializer.Serialize(ref rotationAdaptationSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.RotationAdaptationSpeed = rotationAdaptationSpeed;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterPlayer_AnimationControllerSerializer : ClassDataSerializer<FirstPersonShooter.Player.AnimationController>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.SyncScript> parentSerializer;
		private DataSerializer<SiliconStudio.Xenko.Engine.AnimationComponent> AnimationComponentSerializer;
		private DataSerializer<SiliconStudio.Xenko.Animations.AnimationClip> AnimationIdleSerializer;
		private DataSerializer<SiliconStudio.Xenko.Animations.AnimationClip> AnimationWalkSerializer;
		private DataSerializer<SiliconStudio.Xenko.Animations.AnimationClip> AnimationShootSerializer;
		private DataSerializer<SiliconStudio.Xenko.Animations.AnimationClip> AnimationReloadSerializer;
		private DataSerializer<System.Double> TimeFactorSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.SyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.SyncScript"));
			// Cache member serializers
			AnimationComponentSerializer = MemberSerializer<SiliconStudio.Xenko.Engine.AnimationComponent>.Create(serializerSelector);
			AnimationIdleSerializer = MemberSerializer<SiliconStudio.Xenko.Animations.AnimationClip>.Create(serializerSelector);
			TimeFactorSerializer = MemberSerializer<System.Double>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Player.AnimationController obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.SyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.Player.AnimationController)parentObj;

            SiliconStudio.Xenko.Engine.AnimationComponent animationComponent = mode == ArchiveMode.Serialize ? obj.AnimationComponent : default(SiliconStudio.Xenko.Engine.AnimationComponent);
            AnimationComponentSerializer.Serialize(ref animationComponent, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.AnimationComponent = animationComponent;
            SiliconStudio.Xenko.Animations.AnimationClip animationIdle = mode == ArchiveMode.Serialize ? obj.AnimationIdle : default(SiliconStudio.Xenko.Animations.AnimationClip);
            AnimationIdleSerializer.Serialize(ref animationIdle, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.AnimationIdle = animationIdle;
            SiliconStudio.Xenko.Animations.AnimationClip animationWalk = mode == ArchiveMode.Serialize ? obj.AnimationWalk : default(SiliconStudio.Xenko.Animations.AnimationClip);
            AnimationIdleSerializer.Serialize(ref animationWalk, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.AnimationWalk = animationWalk;
            SiliconStudio.Xenko.Animations.AnimationClip animationShoot = mode == ArchiveMode.Serialize ? obj.AnimationShoot : default(SiliconStudio.Xenko.Animations.AnimationClip);
            AnimationIdleSerializer.Serialize(ref animationShoot, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.AnimationShoot = animationShoot;
            SiliconStudio.Xenko.Animations.AnimationClip animationReload = mode == ArchiveMode.Serialize ? obj.AnimationReload : default(SiliconStudio.Xenko.Animations.AnimationClip);
            AnimationIdleSerializer.Serialize(ref animationReload, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.AnimationReload = animationReload;
            System.Double timeFactor = mode == ArchiveMode.Serialize ? obj.TimeFactor : default(System.Double);
            TimeFactorSerializer.Serialize(ref timeFactor, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.TimeFactor = timeFactor;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterPlayer_PlayerControllerSerializer : ClassDataSerializer<FirstPersonShooter.Player.PlayerController>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.SyncScript> parentSerializer;
		private DataSerializer<System.Single> MaxRunSpeedSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.SyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.SyncScript"));
			// Cache member serializers
			MaxRunSpeedSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Player.PlayerController obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.SyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.Player.PlayerController)parentObj;

            System.Single maxRunSpeed = mode == ArchiveMode.Serialize ? obj.MaxRunSpeed : default(System.Single);
            MaxRunSpeedSerializer.Serialize(ref maxRunSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.MaxRunSpeed = maxRunSpeed;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterPlayer_PlayerInputSerializer : ClassDataSerializer<FirstPersonShooter.Player.PlayerInput>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.SyncScript> parentSerializer;
		private DataSerializer<System.Single> DeadZoneSerializer;
		private DataSerializer<SiliconStudio.Xenko.Engine.CameraComponent> CameraSerializer;
		private DataSerializer<System.Single> MouseSensitivitySerializer;
		private DataSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>> KeysLeftSerializer;
		private DataSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>> KeysRightSerializer;
		private DataSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>> KeysUpSerializer;
		private DataSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>> KeysDownSerializer;
		private DataSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>> KeysReloadSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.SyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.SyncScript"));
			// Cache member serializers
			DeadZoneSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
			CameraSerializer = MemberSerializer<SiliconStudio.Xenko.Engine.CameraComponent>.Create(serializerSelector);
			KeysLeftSerializer = MemberSerializer<System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys>>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Player.PlayerInput obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.SyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.Player.PlayerInput)parentObj;

            System.Single deadZone = mode == ArchiveMode.Serialize ? obj.DeadZone : default(System.Single);
            DeadZoneSerializer.Serialize(ref deadZone, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.DeadZone = deadZone;
            SiliconStudio.Xenko.Engine.CameraComponent camera = mode == ArchiveMode.Serialize ? obj.Camera : default(SiliconStudio.Xenko.Engine.CameraComponent);
            CameraSerializer.Serialize(ref camera, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Camera = camera;
            System.Single mouseSensitivity = mode == ArchiveMode.Serialize ? obj.MouseSensitivity : default(System.Single);
            DeadZoneSerializer.Serialize(ref mouseSensitivity, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.MouseSensitivity = mouseSensitivity;
            System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys> keysLeft = obj.KeysLeft;
            KeysLeftSerializer.Serialize(ref keysLeft, mode, stream);
            System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys> keysRight = obj.KeysRight;
            KeysLeftSerializer.Serialize(ref keysRight, mode, stream);
            System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys> keysUp = obj.KeysUp;
            KeysLeftSerializer.Serialize(ref keysUp, mode, stream);
            System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys> keysDown = obj.KeysDown;
            KeysLeftSerializer.Serialize(ref keysDown, mode, stream);
            System.Collections.Generic.List<SiliconStudio.Xenko.Input.Keys> keysReload = obj.KeysReload;
            KeysLeftSerializer.Serialize(ref keysReload, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class FirstPersonShooterPlayer_WeaponScriptSerializer : ClassDataSerializer<FirstPersonShooter.Player.WeaponScript>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.SyncScript> parentSerializer;
		private DataSerializer<System.Single> MaxShootDistanceSerializer;
		private DataSerializer<System.Single> ShootImpulseSerializer;
		private DataSerializer<System.Single> CooldownSerializer;
		private DataSerializer<System.Single> ReloadCooldownSerializer;
		private DataSerializer<SiliconStudio.Xenko.Engine.SpriteComponent> RemainingBulletsSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.SyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.SyncScript"));
			// Cache member serializers
			MaxShootDistanceSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
			RemainingBulletsSerializer = MemberSerializer<SiliconStudio.Xenko.Engine.SpriteComponent>.Create(serializerSelector);
		}

		public override void Serialize(ref FirstPersonShooter.Player.WeaponScript obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.SyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (FirstPersonShooter.Player.WeaponScript)parentObj;

            System.Single maxShootDistance = mode == ArchiveMode.Serialize ? obj.MaxShootDistance : default(System.Single);
            MaxShootDistanceSerializer.Serialize(ref maxShootDistance, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.MaxShootDistance = maxShootDistance;
            System.Single shootImpulse = mode == ArchiveMode.Serialize ? obj.ShootImpulse : default(System.Single);
            MaxShootDistanceSerializer.Serialize(ref shootImpulse, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.ShootImpulse = shootImpulse;
            System.Single cooldown = mode == ArchiveMode.Serialize ? obj.Cooldown : default(System.Single);
            MaxShootDistanceSerializer.Serialize(ref cooldown, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.Cooldown = cooldown;
            System.Single reloadCooldown = mode == ArchiveMode.Serialize ? obj.ReloadCooldown : default(System.Single);
            MaxShootDistanceSerializer.Serialize(ref reloadCooldown, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.ReloadCooldown = reloadCooldown;
            SiliconStudio.Xenko.Engine.SpriteComponent remainingBullets = mode == ArchiveMode.Serialize ? obj.RemainingBullets : default(SiliconStudio.Xenko.Engine.SpriteComponent);
            RemainingBulletsSerializer.Serialize(ref remainingBullets, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.RemainingBullets = remainingBullets;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}