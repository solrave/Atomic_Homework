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

namespace Game
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class AtomicAPIExtensions
	{

		///Tags
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
		public static readonly int Damage; // IVariable<int>
		public static readonly int TakeDamageRequest; // IRequest<int>
		public static readonly int TakeDamageCondition; // IExpression<int,bool>
		public static readonly int TakeDamageAction; // ICompositeAction<int>
		public static readonly int TakeDamageEvent; // IEvent<int>

		static AtomicAPIExtensions()
		{
			//Tags
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
			Damage = NameToId(nameof(Damage));
			TakeDamageRequest = NameToId(nameof(TakeDamageRequest));
			TakeDamageCondition = NameToId(nameof(TakeDamageCondition));
			TakeDamageAction = NameToId(nameof(TakeDamageAction));
			TakeDamageEvent = NameToId(nameof(TakeDamageEvent));
		}


		///Tag Extensions

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
    }
}
