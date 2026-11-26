/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using static Atomic.Entities.EntityNames;
using System.Runtime.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Game;
using Game.UI;

namespace Game
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class UIContextAPI
	{
		///Values
		public static readonly int HealthView; // HealthScreenView
		public static readonly int HealthCount; // StatView
		public static readonly int AmmoCount; // StatView
		public static readonly int KillCount; // StatView

		static UIContextAPI()
		{
			//Values
			HealthView = NameToId(nameof(HealthView));
			HealthCount = NameToId(nameof(HealthCount));
			AmmoCount = NameToId(nameof(AmmoCount));
			KillCount = NameToId(nameof(KillCount));
		}


		///Value Extensions

		#region HealthView

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static HealthScreenView GetHealthView(this IGameUI entity) => entity.GetValue<HealthScreenView>(HealthView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealthView(this IGameUI entity, out HealthScreenView value) => entity.TryGetValue(HealthView, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddHealthView(this IGameUI entity, HealthScreenView value) => entity.AddValue(HealthView, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealthView(this IGameUI entity) => entity.HasValue(HealthView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealthView(this IGameUI entity) => entity.DelValue(HealthView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealthView(this IGameUI entity, HealthScreenView value) => entity.SetValue(HealthView, value);

		#endregion

		#region HealthCount

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StatView GetHealthCount(this IGameUI entity) => entity.GetValue<StatView>(HealthCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealthCount(this IGameUI entity, out StatView value) => entity.TryGetValue(HealthCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddHealthCount(this IGameUI entity, StatView value) => entity.AddValue(HealthCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealthCount(this IGameUI entity) => entity.HasValue(HealthCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealthCount(this IGameUI entity) => entity.DelValue(HealthCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealthCount(this IGameUI entity, StatView value) => entity.SetValue(HealthCount, value);

		#endregion

		#region AmmoCount

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StatView GetAmmoCount(this IGameUI entity) => entity.GetValue<StatView>(AmmoCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmmoCount(this IGameUI entity, out StatView value) => entity.TryGetValue(AmmoCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddAmmoCount(this IGameUI entity, StatView value) => entity.AddValue(AmmoCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmmoCount(this IGameUI entity) => entity.HasValue(AmmoCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmmoCount(this IGameUI entity) => entity.DelValue(AmmoCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmmoCount(this IGameUI entity, StatView value) => entity.SetValue(AmmoCount, value);

		#endregion

		#region KillCount

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StatView GetKillCount(this IGameUI entity) => entity.GetValue<StatView>(KillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetKillCount(this IGameUI entity, out StatView value) => entity.TryGetValue(KillCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddKillCount(this IGameUI entity, StatView value) => entity.AddValue(KillCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasKillCount(this IGameUI entity) => entity.HasValue(KillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelKillCount(this IGameUI entity) => entity.DelValue(KillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKillCount(this IGameUI entity, StatView value) => entity.SetValue(KillCount, value);

		#endregion
    }
}
