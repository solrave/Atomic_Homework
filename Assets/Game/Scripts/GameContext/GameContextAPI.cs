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

namespace Game
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class GameContextAPI
	{
		///Values
		public static readonly int BulletPool; // BulletPool
		public static readonly int Player; // IGameEntity

		static GameContextAPI()
		{
			//Values
			BulletPool = NameToId(nameof(BulletPool));
			Player = NameToId(nameof(Player));
		}


		///Value Extensions

		#region BulletPool

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BulletPool GetBulletPool(this IEntity entity) => entity.GetValue<BulletPool>(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletPool(this IEntity entity, out BulletPool value) => entity.TryGetValue(BulletPool, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddBulletPool(this IEntity entity, BulletPool value) => entity.AddValue(BulletPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletPool(this IEntity entity) => entity.HasValue(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletPool(this IEntity entity) => entity.DelValue(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletPool(this IEntity entity, BulletPool value) => entity.SetValue(BulletPool, value);

		#endregion

		#region Player

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IGameEntity GetPlayer(this IEntity entity) => entity.GetValue<IGameEntity>(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayer(this IEntity entity, out IGameEntity value) => entity.TryGetValue(Player, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPlayer(this IEntity entity, IGameEntity value) => entity.AddValue(Player, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayer(this IEntity entity) => entity.HasValue(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayer(this IEntity entity) => entity.DelValue(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayer(this IEntity entity, IGameEntity value) => entity.SetValue(Player, value);

		#endregion
    }
}
