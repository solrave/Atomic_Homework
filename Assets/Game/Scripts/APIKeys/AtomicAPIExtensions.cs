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
using Unity.Mathematics;

namespace Game
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class AtomicAPIExtensions
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
		public static readonly int CurrentHealth; // IReactiveVariable<int>
		public static readonly int MaxHealth; // IValue<int>
		public static readonly int DeathEvent; // IEvent<IEntity>
		public static readonly int HitCollider; // Collider
		public static readonly int TakeDamageRequest; // IRequest<int>
		public static readonly int TakeDamageCondition; // IExpression<int,bool>
		public static readonly int TakeDamageAction; // ICompositeAction<int>
		public static readonly int TakeDamageEvent; // IEvent<int>
		public static readonly int Damage; // IVariable<int>
		public static readonly int AttackRequest; // IRequest
		public static readonly int AttackCondition; // IExpression<bool>
		public static readonly int AttackAction; // ICompositeAction
		public static readonly int AttackEvent; // IEvent
		public static readonly int AttackCooldown; // ICooldown
		public static readonly int Weapon; // IVariable<IEntity>
		public static readonly int Ammo; // IVariable<int>
		public static readonly int SpreadAngle; // Const<float>
		public static readonly int HitDelay; // DownTimer
		public static readonly int LifeTime; // DownTimer
		public static readonly int Trigger; // TriggerEvents
		public static readonly int SphereCastRadius; // Const<float>
		public static readonly int LayerMask; // Const<LayerMask>
		public static readonly int TriggerEnemies; // List<SceneEntity>
		public static readonly int Target; // IVariable<IEntity>
		public static readonly int AttackDistance; // Const<float>
		public static readonly int PickupRequest; // IRequest<IEntity>
		public static readonly int PickupCondition; // AndExpression<IEntity>
		public static readonly int PickupAction; // ICompositeAction<IEntity>
		public static readonly int PickupEvent; // IEvent<IEntity>
		public static readonly int VFX; // ParticleSystem
		public static readonly int SFX; // AudioSource
		public static readonly int Amount; // Const<int>

		static AtomicAPIExtensions()
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
			DeathEvent = NameToId(nameof(DeathEvent));
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
			AttackCooldown = NameToId(nameof(AttackCooldown));
			Weapon = NameToId(nameof(Weapon));
			Ammo = NameToId(nameof(Ammo));
			SpreadAngle = NameToId(nameof(SpreadAngle));
			HitDelay = NameToId(nameof(HitDelay));
			LifeTime = NameToId(nameof(LifeTime));
			Trigger = NameToId(nameof(Trigger));
			SphereCastRadius = NameToId(nameof(SphereCastRadius));
			LayerMask = NameToId(nameof(LayerMask));
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
		public static bool HasPlayerTag(this IEntity entity) => entity.HasTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerTag(this IEntity entity) => entity.AddTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerTag(this IEntity entity) => entity.DelTag(Player);

		#endregion

		#region Moveable

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveableTag(this IEntity entity) => entity.HasTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveableTag(this IEntity entity) => entity.AddTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveableTag(this IEntity entity) => entity.DelTag(Moveable);

		#endregion

		#region Damageable

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageableTag(this IEntity entity) => entity.HasTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageableTag(this IEntity entity) => entity.AddTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageableTag(this IEntity entity) => entity.DelTag(Damageable);

		#endregion

		#region Alive

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAliveTag(this IEntity entity) => entity.HasTag(Alive);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAliveTag(this IEntity entity) => entity.AddTag(Alive);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAliveTag(this IEntity entity) => entity.DelTag(Alive);

		#endregion


		///Value Extensions

		#region Animator

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IEntity entity) => entity.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IEntity entity, out Animator value) => entity.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAnimator(this IEntity entity, Animator value) => entity.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IEntity entity) => entity.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IEntity entity) => entity.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IEntity entity, Animator value) => entity.SetValue(Animator, value);

		#endregion

		#region MoveRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<Vector3> GetMoveRequest(this IEntity entity) => entity.GetValue<IRequest<Vector3>>(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveRequest(this IEntity entity, out IRequest<Vector3> value) => entity.TryGetValue(MoveRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveRequest(this IEntity entity, IRequest<Vector3> value) => entity.AddValue(MoveRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveRequest(this IEntity entity) => entity.HasValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveRequest(this IEntity entity) => entity.DelValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveRequest(this IEntity entity, IRequest<Vector3> value) => entity.SetValue(MoveRequest, value);

		#endregion

		#region MoveCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<Vector3,bool> GetMoveCondition(this IEntity entity) => entity.GetValue<IExpression<Vector3,bool>>(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveCondition(this IEntity entity, out IExpression<Vector3,bool> value) => entity.TryGetValue(MoveCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveCondition(this IEntity entity, IExpression<Vector3,bool> value) => entity.AddValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveCondition(this IEntity entity) => entity.HasValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveCondition(this IEntity entity) => entity.DelValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveCondition(this IEntity entity, IExpression<Vector3,bool> value) => entity.SetValue(MoveCondition, value);

		#endregion

		#region MoveAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<Vector3,float> GetMoveAction(this IEntity entity) => entity.GetValue<ICompositeAction<Vector3,float>>(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveAction(this IEntity entity, out ICompositeAction<Vector3,float> value) => entity.TryGetValue(MoveAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveAction(this IEntity entity, ICompositeAction<Vector3,float> value) => entity.AddValue(MoveAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveAction(this IEntity entity) => entity.HasValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveAction(this IEntity entity) => entity.DelValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveAction(this IEntity entity, ICompositeAction<Vector3,float> value) => entity.SetValue(MoveAction, value);

		#endregion

		#region MoveEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<Vector3> GetMoveEvent(this IEntity entity) => entity.GetValue<IEvent<Vector3>>(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveEvent(this IEntity entity, out IEvent<Vector3> value) => entity.TryGetValue(MoveEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveEvent(this IEntity entity, IEvent<Vector3> value) => entity.AddValue(MoveEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveEvent(this IEntity entity) => entity.HasValue(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveEvent(this IEntity entity) => entity.DelValue(MoveEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveEvent(this IEntity entity, IEvent<Vector3> value) => entity.SetValue(MoveEvent, value);

		#endregion

		#region LookDirection

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVector3 GetLookDirection(this IEntity entity) => entity.GetValue<ReactiveVector3>(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLookDirection(this IEntity entity, out ReactiveVector3 value) => entity.TryGetValue(LookDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLookDirection(this IEntity entity, ReactiveVector3 value) => entity.AddValue(LookDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLookDirection(this IEntity entity) => entity.HasValue(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLookDirection(this IEntity entity) => entity.DelValue(LookDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLookDirection(this IEntity entity, ReactiveVector3 value) => entity.SetValue(LookDirection, value);

		#endregion

		#region MoveSpeed

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetMoveSpeed(this IEntity entity) => entity.GetValue<IVariable<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity entity, out IVariable<float> value) => entity.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveSpeed(this IEntity entity, IVariable<float> value) => entity.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity entity) => entity.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity entity) => entity.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity entity, IVariable<float> value) => entity.SetValue(MoveSpeed, value);

		#endregion

		#region RotationSpeed

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetRotationSpeed(this IEntity entity) => entity.GetValue<IVariable<float>>(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotationSpeed(this IEntity entity, out IVariable<float> value) => entity.TryGetValue(RotationSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRotationSpeed(this IEntity entity, IVariable<float> value) => entity.AddValue(RotationSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotationSpeed(this IEntity entity) => entity.HasValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotationSpeed(this IEntity entity) => entity.DelValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotationSpeed(this IEntity entity, IVariable<float> value) => entity.SetValue(RotationSpeed, value);

		#endregion

		#region Rigidbody

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rigidbody GetRigidbody(this IEntity entity) => entity.GetValue<Rigidbody>(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRigidbody(this IEntity entity, out Rigidbody value) => entity.TryGetValue(Rigidbody, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRigidbody(this IEntity entity, Rigidbody value) => entity.AddValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRigidbody(this IEntity entity) => entity.HasValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRigidbody(this IEntity entity) => entity.DelValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRigidbody(this IEntity entity, Rigidbody value) => entity.SetValue(Rigidbody, value);

		#endregion

		#region MoveDuration

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetMoveDuration(this IEntity entity) => entity.GetValue<Const<float>>(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDuration(this IEntity entity, out Const<float> value) => entity.TryGetValue(MoveDuration, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveDuration(this IEntity entity, Const<float> value) => entity.AddValue(MoveDuration, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDuration(this IEntity entity) => entity.HasValue(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDuration(this IEntity entity) => entity.DelValue(MoveDuration);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDuration(this IEntity entity, Const<float> value) => entity.SetValue(MoveDuration, value);

		#endregion

		#region MoveTime

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<float> GetMoveTime(this IEntity entity) => entity.GetValue<IVariable<float>>(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveTime(this IEntity entity, out IVariable<float> value) => entity.TryGetValue(MoveTime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveTime(this IEntity entity, IVariable<float> value) => entity.AddValue(MoveTime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveTime(this IEntity entity) => entity.HasValue(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveTime(this IEntity entity) => entity.DelValue(MoveTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveTime(this IEntity entity, IVariable<float> value) => entity.SetValue(MoveTime, value);

		#endregion

		#region CurrentHealth

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetCurrentHealth(this IEntity entity) => entity.GetValue<IReactiveVariable<int>>(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentHealth(this IEntity entity, out IReactiveVariable<int> value) => entity.TryGetValue(CurrentHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddCurrentHealth(this IEntity entity, IReactiveVariable<int> value) => entity.AddValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentHealth(this IEntity entity) => entity.HasValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentHealth(this IEntity entity) => entity.DelValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentHealth(this IEntity entity, IReactiveVariable<int> value) => entity.SetValue(CurrentHealth, value);

		#endregion

		#region MaxHealth

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<int> GetMaxHealth(this IEntity entity) => entity.GetValue<IValue<int>>(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxHealth(this IEntity entity, out IValue<int> value) => entity.TryGetValue(MaxHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMaxHealth(this IEntity entity, IValue<int> value) => entity.AddValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxHealth(this IEntity entity) => entity.HasValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxHealth(this IEntity entity) => entity.DelValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxHealth(this IEntity entity, IValue<int> value) => entity.SetValue(MaxHealth, value);

		#endregion

		#region DeathEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<IEntity> GetDeathEvent(this IEntity entity) => entity.GetValue<IEvent<IEntity>>(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDeathEvent(this IEntity entity, out IEvent<IEntity> value) => entity.TryGetValue(DeathEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddDeathEvent(this IEntity entity, IEvent<IEntity> value) => entity.AddValue(DeathEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDeathEvent(this IEntity entity) => entity.HasValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDeathEvent(this IEntity entity) => entity.DelValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDeathEvent(this IEntity entity, IEvent<IEntity> value) => entity.SetValue(DeathEvent, value);

		#endregion

		#region HitCollider

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Collider GetHitCollider(this IEntity entity) => entity.GetValue<Collider>(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHitCollider(this IEntity entity, out Collider value) => entity.TryGetValue(HitCollider, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddHitCollider(this IEntity entity, Collider value) => entity.AddValue(HitCollider, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHitCollider(this IEntity entity) => entity.HasValue(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHitCollider(this IEntity entity) => entity.DelValue(HitCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHitCollider(this IEntity entity, Collider value) => entity.SetValue(HitCollider, value);

		#endregion

		#region TakeDamageRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<int> GetTakeDamageRequest(this IEntity entity) => entity.GetValue<IRequest<int>>(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageRequest(this IEntity entity, out IRequest<int> value) => entity.TryGetValue(TakeDamageRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageRequest(this IEntity entity, IRequest<int> value) => entity.AddValue(TakeDamageRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageRequest(this IEntity entity) => entity.HasValue(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageRequest(this IEntity entity) => entity.DelValue(TakeDamageRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageRequest(this IEntity entity, IRequest<int> value) => entity.SetValue(TakeDamageRequest, value);

		#endregion

		#region TakeDamageCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<int,bool> GetTakeDamageCondition(this IEntity entity) => entity.GetValue<IExpression<int,bool>>(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageCondition(this IEntity entity, out IExpression<int,bool> value) => entity.TryGetValue(TakeDamageCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageCondition(this IEntity entity, IExpression<int,bool> value) => entity.AddValue(TakeDamageCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageCondition(this IEntity entity) => entity.HasValue(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageCondition(this IEntity entity) => entity.DelValue(TakeDamageCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageCondition(this IEntity entity, IExpression<int,bool> value) => entity.SetValue(TakeDamageCondition, value);

		#endregion

		#region TakeDamageAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<int> GetTakeDamageAction(this IEntity entity) => entity.GetValue<ICompositeAction<int>>(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageAction(this IEntity entity, out ICompositeAction<int> value) => entity.TryGetValue(TakeDamageAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageAction(this IEntity entity, ICompositeAction<int> value) => entity.AddValue(TakeDamageAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageAction(this IEntity entity) => entity.HasValue(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageAction(this IEntity entity) => entity.DelValue(TakeDamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageAction(this IEntity entity, ICompositeAction<int> value) => entity.SetValue(TakeDamageAction, value);

		#endregion

		#region TakeDamageEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<int> GetTakeDamageEvent(this IEntity entity) => entity.GetValue<IEvent<int>>(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageEvent(this IEntity entity, out IEvent<int> value) => entity.TryGetValue(TakeDamageEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTakeDamageEvent(this IEntity entity, IEvent<int> value) => entity.AddValue(TakeDamageEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageEvent(this IEntity entity) => entity.HasValue(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageEvent(this IEntity entity) => entity.DelValue(TakeDamageEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageEvent(this IEntity entity, IEvent<int> value) => entity.SetValue(TakeDamageEvent, value);

		#endregion

		#region Damage

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<int> GetDamage(this IEntity entity) => entity.GetValue<IVariable<int>>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IEntity entity, out IVariable<int> value) => entity.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddDamage(this IEntity entity, IVariable<int> value) => entity.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IEntity entity) => entity.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IEntity entity) => entity.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IEntity entity, IVariable<int> value) => entity.SetValue(Damage, value);

		#endregion

		#region AttackRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest GetAttackRequest(this IEntity entity) => entity.GetValue<IRequest>(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackRequest(this IEntity entity, out IRequest value) => entity.TryGetValue(AttackRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackRequest(this IEntity entity, IRequest value) => entity.AddValue(AttackRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackRequest(this IEntity entity) => entity.HasValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackRequest(this IEntity entity) => entity.DelValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackRequest(this IEntity entity, IRequest value) => entity.SetValue(AttackRequest, value);

		#endregion

		#region AttackCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetAttackCondition(this IEntity entity) => entity.GetValue<IExpression<bool>>(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackCondition(this IEntity entity, out IExpression<bool> value) => entity.TryGetValue(AttackCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackCondition(this IEntity entity, IExpression<bool> value) => entity.AddValue(AttackCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackCondition(this IEntity entity) => entity.HasValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackCondition(this IEntity entity) => entity.DelValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackCondition(this IEntity entity, IExpression<bool> value) => entity.SetValue(AttackCondition, value);

		#endregion

		#region AttackAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction GetAttackAction(this IEntity entity) => entity.GetValue<ICompositeAction>(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackAction(this IEntity entity, out ICompositeAction value) => entity.TryGetValue(AttackAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackAction(this IEntity entity, ICompositeAction value) => entity.AddValue(AttackAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackAction(this IEntity entity) => entity.HasValue(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackAction(this IEntity entity) => entity.DelValue(AttackAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackAction(this IEntity entity, ICompositeAction value) => entity.SetValue(AttackAction, value);

		#endregion

		#region AttackEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetAttackEvent(this IEntity entity) => entity.GetValue<IEvent>(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackEvent(this IEntity entity, out IEvent value) => entity.TryGetValue(AttackEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackEvent(this IEntity entity, IEvent value) => entity.AddValue(AttackEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackEvent(this IEntity entity) => entity.HasValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackEvent(this IEntity entity) => entity.DelValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackEvent(this IEntity entity, IEvent value) => entity.SetValue(AttackEvent, value);

		#endregion

		#region AttackCooldown

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICooldown GetAttackCooldown(this IEntity entity) => entity.GetValue<ICooldown>(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackCooldown(this IEntity entity, out ICooldown value) => entity.TryGetValue(AttackCooldown, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackCooldown(this IEntity entity, ICooldown value) => entity.AddValue(AttackCooldown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackCooldown(this IEntity entity) => entity.HasValue(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackCooldown(this IEntity entity) => entity.DelValue(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackCooldown(this IEntity entity, ICooldown value) => entity.SetValue(AttackCooldown, value);

		#endregion

		#region Weapon

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<IEntity> GetWeapon(this IEntity entity) => entity.GetValue<IVariable<IEntity>>(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeapon(this IEntity entity, out IVariable<IEntity> value) => entity.TryGetValue(Weapon, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddWeapon(this IEntity entity, IVariable<IEntity> value) => entity.AddValue(Weapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeapon(this IEntity entity) => entity.HasValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeapon(this IEntity entity) => entity.DelValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeapon(this IEntity entity, IVariable<IEntity> value) => entity.SetValue(Weapon, value);

		#endregion

		#region Ammo

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<int> GetAmmo(this IEntity entity) => entity.GetValue<IVariable<int>>(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmmo(this IEntity entity, out IVariable<int> value) => entity.TryGetValue(Ammo, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAmmo(this IEntity entity, IVariable<int> value) => entity.AddValue(Ammo, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmmo(this IEntity entity) => entity.HasValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmmo(this IEntity entity) => entity.DelValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmmo(this IEntity entity, IVariable<int> value) => entity.SetValue(Ammo, value);

		#endregion

		#region SpreadAngle

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetSpreadAngle(this IEntity entity) => entity.GetValue<Const<float>>(SpreadAngle);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSpreadAngle(this IEntity entity, out Const<float> value) => entity.TryGetValue(SpreadAngle, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSpreadAngle(this IEntity entity, Const<float> value) => entity.AddValue(SpreadAngle, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSpreadAngle(this IEntity entity) => entity.HasValue(SpreadAngle);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSpreadAngle(this IEntity entity) => entity.DelValue(SpreadAngle);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSpreadAngle(this IEntity entity, Const<float> value) => entity.SetValue(SpreadAngle, value);

		#endregion

		#region HitDelay

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DownTimer GetHitDelay(this IEntity entity) => entity.GetValue<DownTimer>(HitDelay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHitDelay(this IEntity entity, out DownTimer value) => entity.TryGetValue(HitDelay, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddHitDelay(this IEntity entity, DownTimer value) => entity.AddValue(HitDelay, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHitDelay(this IEntity entity) => entity.HasValue(HitDelay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHitDelay(this IEntity entity) => entity.DelValue(HitDelay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHitDelay(this IEntity entity, DownTimer value) => entity.SetValue(HitDelay, value);

		#endregion

		#region LifeTime

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DownTimer GetLifeTime(this IEntity entity) => entity.GetValue<DownTimer>(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifeTime(this IEntity entity, out DownTimer value) => entity.TryGetValue(LifeTime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLifeTime(this IEntity entity, DownTimer value) => entity.AddValue(LifeTime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifeTime(this IEntity entity) => entity.HasValue(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifeTime(this IEntity entity) => entity.DelValue(LifeTime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifeTime(this IEntity entity, DownTimer value) => entity.SetValue(LifeTime, value);

		#endregion

		#region Trigger

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerEvents GetTrigger(this IEntity entity) => entity.GetValue<TriggerEvents>(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTrigger(this IEntity entity, out TriggerEvents value) => entity.TryGetValue(Trigger, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTrigger(this IEntity entity, TriggerEvents value) => entity.AddValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTrigger(this IEntity entity) => entity.HasValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTrigger(this IEntity entity) => entity.DelValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTrigger(this IEntity entity, TriggerEvents value) => entity.SetValue(Trigger, value);

		#endregion

		#region SphereCastRadius

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetSphereCastRadius(this IEntity entity) => entity.GetValue<Const<float>>(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSphereCastRadius(this IEntity entity, out Const<float> value) => entity.TryGetValue(SphereCastRadius, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSphereCastRadius(this IEntity entity, Const<float> value) => entity.AddValue(SphereCastRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSphereCastRadius(this IEntity entity) => entity.HasValue(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSphereCastRadius(this IEntity entity) => entity.DelValue(SphereCastRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSphereCastRadius(this IEntity entity, Const<float> value) => entity.SetValue(SphereCastRadius, value);

		#endregion

		#region LayerMask

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<LayerMask> GetLayerMask(this IEntity entity) => entity.GetValue<Const<LayerMask>>(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLayerMask(this IEntity entity, out Const<LayerMask> value) => entity.TryGetValue(LayerMask, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLayerMask(this IEntity entity, Const<LayerMask> value) => entity.AddValue(LayerMask, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLayerMask(this IEntity entity) => entity.HasValue(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLayerMask(this IEntity entity) => entity.DelValue(LayerMask);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLayerMask(this IEntity entity, Const<LayerMask> value) => entity.SetValue(LayerMask, value);

		#endregion

		#region TriggerEnemies

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static List<SceneEntity> GetTriggerEnemies(this IEntity entity) => entity.GetValue<List<SceneEntity>>(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerEnemies(this IEntity entity, out List<SceneEntity> value) => entity.TryGetValue(TriggerEnemies, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTriggerEnemies(this IEntity entity, List<SceneEntity> value) => entity.AddValue(TriggerEnemies, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerEnemies(this IEntity entity) => entity.HasValue(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerEnemies(this IEntity entity) => entity.DelValue(TriggerEnemies);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerEnemies(this IEntity entity, List<SceneEntity> value) => entity.SetValue(TriggerEnemies, value);

		#endregion

		#region Target

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<IEntity> GetTarget(this IEntity entity) => entity.GetValue<IVariable<IEntity>>(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IEntity entity, out IVariable<IEntity> value) => entity.TryGetValue(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTarget(this IEntity entity, IVariable<IEntity> value) => entity.AddValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IEntity entity) => entity.HasValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IEntity entity) => entity.DelValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IEntity entity, IVariable<IEntity> value) => entity.SetValue(Target, value);

		#endregion

		#region AttackDistance

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<float> GetAttackDistance(this IEntity entity) => entity.GetValue<Const<float>>(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackDistance(this IEntity entity, out Const<float> value) => entity.TryGetValue(AttackDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAttackDistance(this IEntity entity, Const<float> value) => entity.AddValue(AttackDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackDistance(this IEntity entity) => entity.HasValue(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackDistance(this IEntity entity) => entity.DelValue(AttackDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackDistance(this IEntity entity, Const<float> value) => entity.SetValue(AttackDistance, value);

		#endregion

		#region PickupRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<IEntity> GetPickupRequest(this IEntity entity) => entity.GetValue<IRequest<IEntity>>(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupRequest(this IEntity entity, out IRequest<IEntity> value) => entity.TryGetValue(PickupRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupRequest(this IEntity entity, IRequest<IEntity> value) => entity.AddValue(PickupRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupRequest(this IEntity entity) => entity.HasValue(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupRequest(this IEntity entity) => entity.DelValue(PickupRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupRequest(this IEntity entity, IRequest<IEntity> value) => entity.SetValue(PickupRequest, value);

		#endregion

		#region PickupCondition

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AndExpression<IEntity> GetPickupCondition(this IEntity entity) => entity.GetValue<AndExpression<IEntity>>(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupCondition(this IEntity entity, out AndExpression<IEntity> value) => entity.TryGetValue(PickupCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupCondition(this IEntity entity, AndExpression<IEntity> value) => entity.AddValue(PickupCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupCondition(this IEntity entity) => entity.HasValue(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupCondition(this IEntity entity) => entity.DelValue(PickupCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupCondition(this IEntity entity, AndExpression<IEntity> value) => entity.SetValue(PickupCondition, value);

		#endregion

		#region PickupAction

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ICompositeAction<IEntity> GetPickupAction(this IEntity entity) => entity.GetValue<ICompositeAction<IEntity>>(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupAction(this IEntity entity, out ICompositeAction<IEntity> value) => entity.TryGetValue(PickupAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupAction(this IEntity entity, ICompositeAction<IEntity> value) => entity.AddValue(PickupAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupAction(this IEntity entity) => entity.HasValue(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupAction(this IEntity entity) => entity.DelValue(PickupAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupAction(this IEntity entity, ICompositeAction<IEntity> value) => entity.SetValue(PickupAction, value);

		#endregion

		#region PickupEvent

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<IEntity> GetPickupEvent(this IEntity entity) => entity.GetValue<IEvent<IEntity>>(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupEvent(this IEntity entity, out IEvent<IEntity> value) => entity.TryGetValue(PickupEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupEvent(this IEntity entity, IEvent<IEntity> value) => entity.AddValue(PickupEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupEvent(this IEntity entity) => entity.HasValue(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupEvent(this IEntity entity) => entity.DelValue(PickupEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupEvent(this IEntity entity, IEvent<IEntity> value) => entity.SetValue(PickupEvent, value);

		#endregion

		#region VFX

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ParticleSystem GetVFX(this IEntity entity) => entity.GetValue<ParticleSystem>(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetVFX(this IEntity entity, out ParticleSystem value) => entity.TryGetValue(VFX, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddVFX(this IEntity entity, ParticleSystem value) => entity.AddValue(VFX, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasVFX(this IEntity entity) => entity.HasValue(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelVFX(this IEntity entity) => entity.DelValue(VFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetVFX(this IEntity entity, ParticleSystem value) => entity.SetValue(VFX, value);

		#endregion

		#region SFX

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AudioSource GetSFX(this IEntity entity) => entity.GetValue<AudioSource>(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSFX(this IEntity entity, out AudioSource value) => entity.TryGetValue(SFX, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSFX(this IEntity entity, AudioSource value) => entity.AddValue(SFX, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSFX(this IEntity entity) => entity.HasValue(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSFX(this IEntity entity) => entity.DelValue(SFX);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSFX(this IEntity entity, AudioSource value) => entity.SetValue(SFX, value);

		#endregion

		#region Amount

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<int> GetAmount(this IEntity entity) => entity.GetValue<Const<int>>(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmount(this IEntity entity, out Const<int> value) => entity.TryGetValue(Amount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAmount(this IEntity entity, Const<int> value) => entity.AddValue(Amount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmount(this IEntity entity) => entity.HasValue(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmount(this IEntity entity) => entity.DelValue(Amount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmount(this IEntity entity, Const<int> value) => entity.SetValue(Amount, value);

		#endregion
    }
}
