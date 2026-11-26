/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using static Atomic.Entities.EntityNames;
using System.Runtime.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using Atomic.Elements;
using System.Collections.Generic;

namespace Game
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class GameEntityAPI
	{

		///Tags
		public static readonly int Player;
		public static readonly int Moveable;
		public static readonly int Damageable;
		public static readonly int Alive;

		///Values
		public static readonly int Animator; // Animator
		public static readonly int MoveRequest; // IRequest<Vector3>
		public static readonly int MoveCondition; // IExpression<Vector3,bool>
		public static readonly int MoveAction; // ICompositeAction<Vector3,float>
		public static readonly int MoveEvent; // IEvent<Vector3>
		public static readonly int LookDirection; // ReactiveVector3
		public static readonly int MoveSpeed; // IVariable<float>
		public static readonly int RotationSpeed; // IVariable<float>
		public static readonly int Rigidbody; // Rigidbody
		public static readonly int MoveDuration; // Const<float>
		public static readonly int MoveTime; // IVariable<float>
		public static readonly int CurrentHealth; // IReactiveVariable<float>
		public static readonly int MaxHealth; // IValue<float>
		public static readonly int HitCollider; // Collider
		public static readonly int TakeDamageRequest; // IRequest<float>
		public static readonly int TakeDamageCondition; // IExpression<float,bool>
		public static readonly int TakeDamageAction; // ICompositeAction<float>
		public static readonly int TakeDamageEvent; // IEvent<float>
		public static readonly int Damage; // IVariable<int>
		public static readonly int AttackRequest; // IRequest<Vector3>
		public static readonly int AttackCondition; // IExpression<bool>
		public static readonly int AttackAction; // ICompositeAction<Vector3>
		public static readonly int AttackEvent; // IEvent
		public static readonly int Weapon; // IVariable<IGameEntity>
		public static readonly int Ammo; // IReactiveVariable<float>
		public static readonly int LifeTime; // DownTimer
		public static readonly int Trigger; // TriggerEvents
		public static readonly int SphereCastRadius; // Const<float>
		public static readonly int LayerMask; // Const<LayerMask>
		public static readonly int DespawnEvent; // IEvent
		public static readonly int TriggerEnemies; // List<GameEntity>
		public static readonly int Target; // IVariable<IGameEntity>
		public static readonly int AttackDistance; // Const<float>
		public static readonly int PickupRequest; // IRequest<IGameEntity>
		public static readonly int PickupCondition; // AndExpression<IGameEntity>
		public static readonly int PickupAction; // ICompositeAction<IGameEntity>
		public static readonly int PickupEvent; // IEvent<IGameEntity>
		public static readonly int VFX; // ParticleSystem
		public static readonly int SFX; // AudioSource
		public static readonly int Amount; // Const<int>

		static GameEntityAPI()
		{
			//Tags
			Player = NameToId(nameof(Player));
			Moveable = NameToId(nameof(Moveable));
			Damageable = NameToId(nameof(Damageable));
			Alive = NameToId(nameof(Alive));

			//Values
			Animator = NameToId(nameof(Animator));
			MoveRequest = NameToId(nameof(MoveRequest));
			MoveCondition = NameToId(nameof(MoveCondition));
			MoveAction = NameToId(nameof(MoveAction));
			MoveEvent = NameToId(nameof(MoveEvent));
			LookDirection = NameToId(nameof(LookDirection));
			MoveSpeed = NameToId(nameof(MoveSpeed));
			RotationSpeed = NameToId(nameof(RotationSpeed));
			Rigidbody = NameToId(nameof(Rigidbody));
			MoveDuration = NameToId(nameof(MoveDuration));
			MoveTime = NameToId(nameof(MoveTime));
			CurrentHealth = NameToId(nameof(CurrentHealth));
			MaxHealth = NameToId(nameof(MaxHealth));
			HitCollider = NameToId(nameof(HitCollider));
			TakeDamageRequest = NameToId(nameof(TakeDamageRequest));
			TakeDamageCondition = NameToId(nameof(TakeDamageCondition));
			TakeDamageAction = NameToId(nameof(TakeDamageAction));
			TakeDamageEvent = NameToId(nameof(TakeDamageEvent));
			Damage = NameToId(nameof(Damage));
			AttackRequest = NameToId(nameof(AttackRequest));
			AttackCondition = NameToId(nameof(AttackCondition));
			AttackAction = NameToId(nameof(AttackAction));
			AttackEvent = NameToId(nameof(AttackEvent));
			Weapon = NameToId(nameof(Weapon));
			Ammo = NameToId(nameof(Ammo));
			LifeTime = NameToId(nameof(LifeTime));
			Trigger = NameToId(nameof(Trigger));
			SphereCastRadius = NameToId(nameof(SphereCastRadius));
			LayerMask = NameToId(nameof(LayerMask));
			DespawnEvent = NameToId(nameof(DespawnEvent));
			TriggerEnemies = NameToId(nameof(TriggerEnemies));
			Target = NameToId(nameof(Target));
			AttackDistance = NameToId(nameof(AttackDistance));
			PickupRequest = NameToId(nameof(PickupRequest));
			PickupCondition = NameToId(nameof(PickupCondition));
			PickupAction = NameToId(nameof(PickupAction));
			PickupEvent = NameToId(nameof(PickupEvent));
			VFX = NameToId(nameof(VFX));
			SFX = NameToId(nameof(SFX));
			Amount = NameToId(nameof(Amount));
		}


		///Tag Extensions

		#region Player

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerTag(this IGameEntity entity) => entity.HasTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerTag(this IGameEntity entity) => entity.AddTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerTag(this IGameEntity entity) => entity.DelTag(Player);

		#endregion

		#region Moveable

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveableTag(this IGameEntity entity) => entity.HasTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveableTag(this IGameEntity entity) => entity.AddTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveableTag(this IGameEntity entity) => entity.DelTag(Moveable);

		#endregion

		#region Damageable

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageableTag(this IGameEntity entity) => entity.HasTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageableTag(this IGameEntity entity) => entity.AddTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageableTag(this IGameEntity entity) => entity.DelTag(Damageable);

		#endregion

		#region Alive

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAliveTag(this IGameEntity entity) => entity.HasTag(Alive);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAliveTag(this IGameEntity entity) => entity.AddTag(Alive);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAliveTag(this IGameEntity entity) => entity.DelTag(Alive);

		#endregion


		///Value Extensions

		#region Animator

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IGameEntity entity) => entity.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IGameEntity entity, out Animator value) => entity.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAnimator(this IGameEntity entity, Animator value) => entity.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IGameEntity entity) => entity.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IGameEntity entity) => entity.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IGameEntity entity, Animator value) => entity.SetValue(Animator, value);

		#endregion

		#region MoveRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<Vector3> GetMoveRequest(this IGameEntity entity) => entity.GetValue<IRequest<Vector3>>(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveRequest(this IGameEntity entity, out IRequest<Vector3> value) => entity.TryGetValue(MoveRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.AddValue(MoveRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveRequest(this IGameEntity entity) => entity.HasValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveRequest(this IGameEntity entity) => entity.DelValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.SetValue(MoveRequest, value);

		#endregion

		#region MoveCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<Vector3,bool> GetMoveCondition(this IGameEntity entity) => entity.GetValue<IExpression<Vector3,bool>>(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveCondition(this IGameEntity entity, out IExpression<Vector3,bool> value) => entity.TryGetValue(MoveCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveCondition(this IGameEntity entity, IExpression<Vector3,bool> value) => entity.AddValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveCondition(this IGameEntity entity) => entity.HasValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveCondition(this IGameEntity entity) => entity.DelValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveCondition(this IGameEntity entity, IExpression<Vector3,bool> value) => entity.SetValue(MoveCondition, value);

		#endregion

		#region MoveAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<Vector3,float> GetMoveAction(this IGameEntity entity) => entity.GetValue<ICompositeAction<Vector3,float>>(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveAction(this IGameEntity entity, out ICompositeAction<Vector3,float> value) => entity.TryGetValue(MoveAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveAction(this IGameEntity entity, ICompositeAction<Vector3,float> value) => entity.AddValue(MoveAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveAction(this IGameEntity entity) => entity.HasValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveAction(this IGameEntity entity) => entity.DelValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveAction(this IGameEntity entity, ICompositeAction<Vector3,float> value) => entity.SetValue(MoveAction, value);

		#endregion

		#region MoveEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<Vector3> GetMoveEvent(this IGameEntity entity) => entity.GetValue<IEvent<Vector3>>(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveEvent(this IGameEntity entity, out IEvent<Vector3> value) => entity.TryGetValue(MoveEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveEvent(this IGameEntity entity, IEvent<Vector3> value) => entity.AddValue(MoveEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveEvent(this IGameEntity entity) => entity.HasValue(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveEvent(this IGameEntity entity) => entity.DelValue(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveEvent(this IGameEntity entity, IEvent<Vector3> value) => entity.SetValue(MoveEvent, value);

		#endregion

		#region LookDirection

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVector3 GetLookDirection(this IGameEntity entity) => entity.GetValue<ReactiveVector3>(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLookDirection(this IGameEntity entity, out ReactiveVector3 value) => entity.TryGetValue(LookDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLookDirection(this IGameEntity entity, ReactiveVector3 value) => entity.AddValue(LookDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLookDirection(this IGameEntity entity) => entity.HasValue(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLookDirection(this IGameEntity entity) => entity.DelValue(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLookDirection(this IGameEntity entity, ReactiveVector3 value) => entity.SetValue(LookDirection, value);

		#endregion

		#region MoveSpeed

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetMoveSpeed(this IGameEntity entity) => entity.GetValue<IVariable<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IGameEntity entity, out IVariable<float> value) => entity.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveSpeed(this IGameEntity entity, IVariable<float> value) => entity.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IGameEntity entity) => entity.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IGameEntity entity) => entity.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IGameEntity entity, IVariable<float> value) => entity.SetValue(MoveSpeed, value);

		#endregion

		#region RotationSpeed

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetRotationSpeed(this IGameEntity entity) => entity.GetValue<IVariable<float>>(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotationSpeed(this IGameEntity entity, out IVariable<float> value) => entity.TryGetValue(RotationSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRotationSpeed(this IGameEntity entity, IVariable<float> value) => entity.AddValue(RotationSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotationSpeed(this IGameEntity entity) => entity.HasValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotationSpeed(this IGameEntity entity) => entity.DelValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotationSpeed(this IGameEntity entity, IVariable<float> value) => entity.SetValue(RotationSpeed, value);

		#endregion

		#region Rigidbody

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rigidbody GetRigidbody(this IGameEntity entity) => entity.GetValue<Rigidbody>(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRigidbody(this IGameEntity entity, out Rigidbody value) => entity.TryGetValue(Rigidbody, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRigidbody(this IGameEntity entity, Rigidbody value) => entity.AddValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRigidbody(this IGameEntity entity) => entity.HasValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRigidbody(this IGameEntity entity) => entity.DelValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRigidbody(this IGameEntity entity, Rigidbody value) => entity.SetValue(Rigidbody, value);

		#endregion

		#region MoveDuration

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetMoveDuration(this IGameEntity entity) => entity.GetValue<Const<float>>(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDuration(this IGameEntity entity, out Const<float> value) => entity.TryGetValue(MoveDuration, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveDuration(this IGameEntity entity, Const<float> value) => entity.AddValue(MoveDuration, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDuration(this IGameEntity entity) => entity.HasValue(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDuration(this IGameEntity entity) => entity.DelValue(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDuration(this IGameEntity entity, Const<float> value) => entity.SetValue(MoveDuration, value);

		#endregion

		#region MoveTime

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetMoveTime(this IGameEntity entity) => entity.GetValue<IVariable<float>>(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveTime(this IGameEntity entity, out IVariable<float> value) => entity.TryGetValue(MoveTime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveTime(this IGameEntity entity, IVariable<float> value) => entity.AddValue(MoveTime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveTime(this IGameEntity entity) => entity.HasValue(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveTime(this IGameEntity entity) => entity.DelValue(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveTime(this IGameEntity entity, IVariable<float> value) => entity.SetValue(MoveTime, value);

		#endregion

		#region CurrentHealth

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetCurrentHealth(this IGameEntity entity) => entity.GetValue<IReactiveVariable<float>>(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentHealth(this IGameEntity entity, out IReactiveVariable<float> value) => entity.TryGetValue(CurrentHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddCurrentHealth(this IGameEntity entity, IReactiveVariable<float> value) => entity.AddValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentHealth(this IGameEntity entity) => entity.HasValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentHealth(this IGameEntity entity) => entity.DelValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentHealth(this IGameEntity entity, IReactiveVariable<float> value) => entity.SetValue(CurrentHealth, value);

		#endregion

		#region MaxHealth

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetMaxHealth(this IGameEntity entity) => entity.GetValue<IValue<float>>(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxHealth(this IGameEntity entity, out IValue<float> value) => entity.TryGetValue(MaxHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMaxHealth(this IGameEntity entity, IValue<float> value) => entity.AddValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxHealth(this IGameEntity entity) => entity.HasValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxHealth(this IGameEntity entity) => entity.DelValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxHealth(this IGameEntity entity, IValue<float> value) => entity.SetValue(MaxHealth, value);

		#endregion

		#region HitCollider

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Collider GetHitCollider(this IGameEntity entity) => entity.GetValue<Collider>(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHitCollider(this IGameEntity entity, out Collider value) => entity.TryGetValue(HitCollider, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddHitCollider(this IGameEntity entity, Collider value) => entity.AddValue(HitCollider, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHitCollider(this IGameEntity entity) => entity.HasValue(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHitCollider(this IGameEntity entity) => entity.DelValue(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHitCollider(this IGameEntity entity, Collider value) => entity.SetValue(HitCollider, value);

		#endregion

		#region TakeDamageRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<float> GetTakeDamageRequest(this IGameEntity entity) => entity.GetValue<IRequest<float>>(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageRequest(this IGameEntity entity, out IRequest<float> value) => entity.TryGetValue(TakeDamageRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageRequest(this IGameEntity entity, IRequest<float> value) => entity.AddValue(TakeDamageRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageRequest(this IGameEntity entity) => entity.HasValue(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageRequest(this IGameEntity entity) => entity.DelValue(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageRequest(this IGameEntity entity, IRequest<float> value) => entity.SetValue(TakeDamageRequest, value);

		#endregion

		#region TakeDamageCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<float,bool> GetTakeDamageCondition(this IGameEntity entity) => entity.GetValue<IExpression<float,bool>>(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageCondition(this IGameEntity entity, out IExpression<float,bool> value) => entity.TryGetValue(TakeDamageCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageCondition(this IGameEntity entity, IExpression<float,bool> value) => entity.AddValue(TakeDamageCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageCondition(this IGameEntity entity) => entity.HasValue(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageCondition(this IGameEntity entity) => entity.DelValue(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageCondition(this IGameEntity entity, IExpression<float,bool> value) => entity.SetValue(TakeDamageCondition, value);

		#endregion

		#region TakeDamageAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<float> GetTakeDamageAction(this IGameEntity entity) => entity.GetValue<ICompositeAction<float>>(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageAction(this IGameEntity entity, out ICompositeAction<float> value) => entity.TryGetValue(TakeDamageAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageAction(this IGameEntity entity, ICompositeAction<float> value) => entity.AddValue(TakeDamageAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageAction(this IGameEntity entity) => entity.HasValue(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageAction(this IGameEntity entity) => entity.DelValue(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageAction(this IGameEntity entity, ICompositeAction<float> value) => entity.SetValue(TakeDamageAction, value);

		#endregion

		#region TakeDamageEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<float> GetTakeDamageEvent(this IGameEntity entity) => entity.GetValue<IEvent<float>>(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageEvent(this IGameEntity entity, out IEvent<float> value) => entity.TryGetValue(TakeDamageEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageEvent(this IGameEntity entity, IEvent<float> value) => entity.AddValue(TakeDamageEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageEvent(this IGameEntity entity) => entity.HasValue(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageEvent(this IGameEntity entity) => entity.DelValue(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageEvent(this IGameEntity entity, IEvent<float> value) => entity.SetValue(TakeDamageEvent, value);

		#endregion

		#region Damage

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<int> GetDamage(this IGameEntity entity) => entity.GetValue<IVariable<int>>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IGameEntity entity, out IVariable<int> value) => entity.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddDamage(this IGameEntity entity, IVariable<int> value) => entity.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IGameEntity entity) => entity.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IGameEntity entity) => entity.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IGameEntity entity, IVariable<int> value) => entity.SetValue(Damage, value);

		#endregion

		#region AttackRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<Vector3> GetAttackRequest(this IGameEntity entity) => entity.GetValue<IRequest<Vector3>>(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackRequest(this IGameEntity entity, out IRequest<Vector3> value) => entity.TryGetValue(AttackRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.AddValue(AttackRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackRequest(this IGameEntity entity) => entity.HasValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackRequest(this IGameEntity entity) => entity.DelValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.SetValue(AttackRequest, value);

		#endregion

		#region AttackCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetAttackCondition(this IGameEntity entity) => entity.GetValue<IExpression<bool>>(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackCondition(this IGameEntity entity, out IExpression<bool> value) => entity.TryGetValue(AttackCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackCondition(this IGameEntity entity, IExpression<bool> value) => entity.AddValue(AttackCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackCondition(this IGameEntity entity) => entity.HasValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackCondition(this IGameEntity entity) => entity.DelValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackCondition(this IGameEntity entity, IExpression<bool> value) => entity.SetValue(AttackCondition, value);

		#endregion

		#region AttackAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<Vector3> GetAttackAction(this IGameEntity entity) => entity.GetValue<ICompositeAction<Vector3>>(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackAction(this IGameEntity entity, out ICompositeAction<Vector3> value) => entity.TryGetValue(AttackAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackAction(this IGameEntity entity, ICompositeAction<Vector3> value) => entity.AddValue(AttackAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackAction(this IGameEntity entity) => entity.HasValue(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackAction(this IGameEntity entity) => entity.DelValue(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackAction(this IGameEntity entity, ICompositeAction<Vector3> value) => entity.SetValue(AttackAction, value);

		#endregion

		#region AttackEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetAttackEvent(this IGameEntity entity) => entity.GetValue<IEvent>(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackEvent(this IGameEntity entity, out IEvent value) => entity.TryGetValue(AttackEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackEvent(this IGameEntity entity, IEvent value) => entity.AddValue(AttackEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackEvent(this IGameEntity entity) => entity.HasValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackEvent(this IGameEntity entity) => entity.DelValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackEvent(this IGameEntity entity, IEvent value) => entity.SetValue(AttackEvent, value);

		#endregion

		#region Weapon

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<IGameEntity> GetWeapon(this IGameEntity entity) => entity.GetValue<IVariable<IGameEntity>>(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeapon(this IGameEntity entity, out IVariable<IGameEntity> value) => entity.TryGetValue(Weapon, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddWeapon(this IGameEntity entity, IVariable<IGameEntity> value) => entity.AddValue(Weapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeapon(this IGameEntity entity) => entity.HasValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeapon(this IGameEntity entity) => entity.DelValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeapon(this IGameEntity entity, IVariable<IGameEntity> value) => entity.SetValue(Weapon, value);

		#endregion

		#region Ammo

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetAmmo(this IGameEntity entity) => entity.GetValue<IReactiveVariable<float>>(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmmo(this IGameEntity entity, out IReactiveVariable<float> value) => entity.TryGetValue(Ammo, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAmmo(this IGameEntity entity, IReactiveVariable<float> value) => entity.AddValue(Ammo, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmmo(this IGameEntity entity) => entity.HasValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmmo(this IGameEntity entity) => entity.DelValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmmo(this IGameEntity entity, IReactiveVariable<float> value) => entity.SetValue(Ammo, value);

		#endregion

		#region LifeTime

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DownTimer GetLifeTime(this IGameEntity entity) => entity.GetValue<DownTimer>(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifeTime(this IGameEntity entity, out DownTimer value) => entity.TryGetValue(LifeTime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLifeTime(this IGameEntity entity, DownTimer value) => entity.AddValue(LifeTime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifeTime(this IGameEntity entity) => entity.HasValue(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifeTime(this IGameEntity entity) => entity.DelValue(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifeTime(this IGameEntity entity, DownTimer value) => entity.SetValue(LifeTime, value);

		#endregion

		#region Trigger

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerEvents GetTrigger(this IGameEntity entity) => entity.GetValue<TriggerEvents>(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTrigger(this IGameEntity entity, out TriggerEvents value) => entity.TryGetValue(Trigger, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTrigger(this IGameEntity entity, TriggerEvents value) => entity.AddValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTrigger(this IGameEntity entity) => entity.HasValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTrigger(this IGameEntity entity) => entity.DelValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTrigger(this IGameEntity entity, TriggerEvents value) => entity.SetValue(Trigger, value);

		#endregion

		#region SphereCastRadius

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetSphereCastRadius(this IGameEntity entity) => entity.GetValue<Const<float>>(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSphereCastRadius(this IGameEntity entity, out Const<float> value) => entity.TryGetValue(SphereCastRadius, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSphereCastRadius(this IGameEntity entity, Const<float> value) => entity.AddValue(SphereCastRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSphereCastRadius(this IGameEntity entity) => entity.HasValue(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSphereCastRadius(this IGameEntity entity) => entity.DelValue(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSphereCastRadius(this IGameEntity entity, Const<float> value) => entity.SetValue(SphereCastRadius, value);

		#endregion

		#region LayerMask

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<LayerMask> GetLayerMask(this IGameEntity entity) => entity.GetValue<Const<LayerMask>>(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLayerMask(this IGameEntity entity, out Const<LayerMask> value) => entity.TryGetValue(LayerMask, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLayerMask(this IGameEntity entity, Const<LayerMask> value) => entity.AddValue(LayerMask, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLayerMask(this IGameEntity entity) => entity.HasValue(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLayerMask(this IGameEntity entity) => entity.DelValue(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLayerMask(this IGameEntity entity, Const<LayerMask> value) => entity.SetValue(LayerMask, value);

		#endregion

		#region DespawnEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetDespawnEvent(this IGameEntity entity) => entity.GetValue<IEvent>(DespawnEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDespawnEvent(this IGameEntity entity, out IEvent value) => entity.TryGetValue(DespawnEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddDespawnEvent(this IGameEntity entity, IEvent value) => entity.AddValue(DespawnEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDespawnEvent(this IGameEntity entity) => entity.HasValue(DespawnEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDespawnEvent(this IGameEntity entity) => entity.DelValue(DespawnEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDespawnEvent(this IGameEntity entity, IEvent value) => entity.SetValue(DespawnEvent, value);

		#endregion

		#region TriggerEnemies

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static List<GameEntity> GetTriggerEnemies(this IGameEntity entity) => entity.GetValue<List<GameEntity>>(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerEnemies(this IGameEntity entity, out List<GameEntity> value) => entity.TryGetValue(TriggerEnemies, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTriggerEnemies(this IGameEntity entity, List<GameEntity> value) => entity.AddValue(TriggerEnemies, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerEnemies(this IGameEntity entity) => entity.HasValue(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerEnemies(this IGameEntity entity) => entity.DelValue(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerEnemies(this IGameEntity entity, List<GameEntity> value) => entity.SetValue(TriggerEnemies, value);

		#endregion

		#region Target

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<IGameEntity> GetTarget(this IGameEntity entity) => entity.GetValue<IVariable<IGameEntity>>(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IGameEntity entity, out IVariable<IGameEntity> value) => entity.TryGetValue(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTarget(this IGameEntity entity, IVariable<IGameEntity> value) => entity.AddValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IGameEntity entity) => entity.HasValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IGameEntity entity) => entity.DelValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IGameEntity entity, IVariable<IGameEntity> value) => entity.SetValue(Target, value);

		#endregion

		#region AttackDistance

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetAttackDistance(this IGameEntity entity) => entity.GetValue<Const<float>>(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackDistance(this IGameEntity entity, out Const<float> value) => entity.TryGetValue(AttackDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackDistance(this IGameEntity entity, Const<float> value) => entity.AddValue(AttackDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackDistance(this IGameEntity entity) => entity.HasValue(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackDistance(this IGameEntity entity) => entity.DelValue(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackDistance(this IGameEntity entity, Const<float> value) => entity.SetValue(AttackDistance, value);

		#endregion

		#region PickupRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<IGameEntity> GetPickupRequest(this IGameEntity entity) => entity.GetValue<IRequest<IGameEntity>>(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupRequest(this IGameEntity entity, out IRequest<IGameEntity> value) => entity.TryGetValue(PickupRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupRequest(this IGameEntity entity, IRequest<IGameEntity> value) => entity.AddValue(PickupRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupRequest(this IGameEntity entity) => entity.HasValue(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupRequest(this IGameEntity entity) => entity.DelValue(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupRequest(this IGameEntity entity, IRequest<IGameEntity> value) => entity.SetValue(PickupRequest, value);

		#endregion

		#region PickupCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AndExpression<IGameEntity> GetPickupCondition(this IGameEntity entity) => entity.GetValue<AndExpression<IGameEntity>>(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupCondition(this IGameEntity entity, out AndExpression<IGameEntity> value) => entity.TryGetValue(PickupCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupCondition(this IGameEntity entity, AndExpression<IGameEntity> value) => entity.AddValue(PickupCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupCondition(this IGameEntity entity) => entity.HasValue(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupCondition(this IGameEntity entity) => entity.DelValue(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupCondition(this IGameEntity entity, AndExpression<IGameEntity> value) => entity.SetValue(PickupCondition, value);

		#endregion

		#region PickupAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<IGameEntity> GetPickupAction(this IGameEntity entity) => entity.GetValue<ICompositeAction<IGameEntity>>(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupAction(this IGameEntity entity, out ICompositeAction<IGameEntity> value) => entity.TryGetValue(PickupAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupAction(this IGameEntity entity, ICompositeAction<IGameEntity> value) => entity.AddValue(PickupAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupAction(this IGameEntity entity) => entity.HasValue(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupAction(this IGameEntity entity) => entity.DelValue(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupAction(this IGameEntity entity, ICompositeAction<IGameEntity> value) => entity.SetValue(PickupAction, value);

		#endregion

		#region PickupEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<IGameEntity> GetPickupEvent(this IGameEntity entity) => entity.GetValue<IEvent<IGameEntity>>(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupEvent(this IGameEntity entity, out IEvent<IGameEntity> value) => entity.TryGetValue(PickupEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupEvent(this IGameEntity entity, IEvent<IGameEntity> value) => entity.AddValue(PickupEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupEvent(this IGameEntity entity) => entity.HasValue(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupEvent(this IGameEntity entity) => entity.DelValue(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupEvent(this IGameEntity entity, IEvent<IGameEntity> value) => entity.SetValue(PickupEvent, value);

		#endregion

		#region VFX

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ParticleSystem GetVFX(this IGameEntity entity) => entity.GetValue<ParticleSystem>(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetVFX(this IGameEntity entity, out ParticleSystem value) => entity.TryGetValue(VFX, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddVFX(this IGameEntity entity, ParticleSystem value) => entity.AddValue(VFX, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasVFX(this IGameEntity entity) => entity.HasValue(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelVFX(this IGameEntity entity) => entity.DelValue(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetVFX(this IGameEntity entity, ParticleSystem value) => entity.SetValue(VFX, value);

		#endregion

		#region SFX

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AudioSource GetSFX(this IGameEntity entity) => entity.GetValue<AudioSource>(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSFX(this IGameEntity entity, out AudioSource value) => entity.TryGetValue(SFX, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSFX(this IGameEntity entity, AudioSource value) => entity.AddValue(SFX, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSFX(this IGameEntity entity) => entity.HasValue(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSFX(this IGameEntity entity) => entity.DelValue(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSFX(this IGameEntity entity, AudioSource value) => entity.SetValue(SFX, value);

		#endregion

		#region Amount

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<int> GetAmount(this IGameEntity entity) => entity.GetValue<Const<int>>(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmount(this IGameEntity entity, out Const<int> value) => entity.TryGetValue(Amount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAmount(this IGameEntity entity, Const<int> value) => entity.AddValue(Amount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmount(this IGameEntity entity) => entity.HasValue(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmount(this IGameEntity entity) => entity.DelValue(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmount(this IGameEntity entity, Const<int> value) => entity.SetValue(Amount, value);

		#endregion
    }
}
