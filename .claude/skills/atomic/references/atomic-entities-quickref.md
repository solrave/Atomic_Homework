# Atomic Framework — Entities (quick lookup)

> **Base path:** `Assets/Plugins/Atomic/Entities/`
> See also: [atomic-entities-full.md](atomic-entities-full.md) (exhaustive index)

---

## Frequently Used Components

| Component | Path | Purpose |
|-----------|------|---------|
| `IEntity` | `Scripts/Entities/Interface/IEntity.cs` | Base entity interface: values, tags, behaviours, lifecycle |
| `Entity` | `Scripts/Entities/Core/Entity.cs` | Pure C# `IEntity` without Unity dependencies |
| `SceneEntity` | `Scripts/Entities/Unity/SceneEntity.cs` | MonoBehaviour entity on scene/prefab |
| `SceneEntitySingleton<T>` | `Scripts/Entities/Unity/SceneEntitySingleton.cs` | Scene singleton entity with `Instance` (target: `GameContext`) |
| `SceneEntityProxy<T>` | `Scripts/Entities/Unity/SceneEntityProxy`1.cs` | Proxy delegating to another entity |
| `EntityAPIManager` | `Editor/EntityAPI/EntityAPIManager.cs` | `.atomic` → generated `Add/Get/Set/TryGet/Has/Del{Name}` + `{Tag}Tag` methods (`Tools/Atomic/Entities/Compile Entity API`) |
| `EntityNames` | `Scripts/Names/EntityNames.cs` | Name → int id used by generated API; `ValueKey`/`TagKey` structs live next to it |
| `IEntityInstaller` | `Scripts/Installers/IEntityInstaller.cs` | Installer contract: register values/behaviours at creation |
| `SceneEntityInstaller<T>` | `Scripts/Installers/SceneEntityInstaller`1.cs` | MonoBehaviour installer on prefab/scene entity |
| `ScriptableEntityInstaller<T>` | `Scripts/Installers/ScriptableEntityInstaller`1.cs` | ScriptableObject installer for data-driven setup |
| `IEntityInit` | `Scripts/Behaviours/IEntityInit.cs` | Lifecycle: init behaviour after registration |
| `IEntityTick` | `Scripts/Behaviours/IEntityTick.cs` | Lifecycle: per-frame tick |
| `IEntityFixedTick` | `Scripts/Behaviours/IEntityFixedTick.cs` | Lifecycle: FixedUpdate tick |
| `IEntityEnable` / `IEntityDisable` | `Scripts/Behaviours/IEntityEnable.cs`, `IEntityDisable.cs` | Lifecycle: enable/disable without dispose |
| `IEntityDispose` | `Scripts/Behaviours/IEntityDispose.cs` | Lifecycle: cleanup subscriptions and resources |
| `IEntityBehaviour` | `Scripts/Behaviours/IEntityBehaviour.cs` | Behaviour marker attached to entity |
| `Extensions_Values` | `Scripts/Entities/Extensions_Values.cs` | `AddValue`, `GetValue`, `TryGetValue`, `HasValue`, `DelValue` |
| `Extensions_Behaviours` | `Scripts/Entities/Extensions_Behaviours.cs` | `AddBehaviour`, `DelBehaviour`, `HasBehaviour`, `GetBehaviour` |
| `Extensions_Tags` | `Scripts/Entities/Extensions_Tags.cs` | `AddTag`, `DelTag`, `HasTag` |
| `IEntityWorld` | `Scripts/World/Interface/IEntityWorld.cs` | Container for all entities in a world/scene |
| `SceneEntityWorld<T>` | `Scripts/World/Unity/SceneEntityWorld`1.cs` | Unity world: storage, tick, lifecycle for scene entities |
| `EntityCollection<T>` | `Scripts/Collections/EntityCollection`1.cs` | Reactive entity collection with add/remove/change events |
| `EntityFilter<T>` | `Scripts/Filters/EntityFilter`1.cs` | Filter entities by triggers (tag, value, behaviour) |
| `IEntityFactory<T>` | `Scripts/Factories/Interfaces/IEntityFactory`1.cs` | Entity factory contract |
| `SceneEntityFactory<T>` | `Scripts/Factories/Unity/SceneEntityFactory`1.cs` | MonoBehaviour factory (e.g. bullets) |
| `PrefabEntityPool<T>` | `Scripts/Pooling/Unity/PrefabEntityPool`1.cs` | Prefab-based entity pool |
| `SceneEntityBootstrap` | `Scripts/Bootstrap/SceneEntityBootstrap.cs` | Scene bootstrap: init world and tick manager |
| `TickManager` | `Scripts/Lifecycle/TickManager.cs` | Central dispatcher for tick/fixedTick/lateTick |
| `EntityDomainWindow` | `Editor/EntityDomain/EntityDomainWindow.cs` | `Window/Atomic/Entities/Entity Domain Generator`: generate `IGameEntity` / `IGameContext` domains |
| `IEntityAspect` | `Scripts/Aspects/IEntityAspect.cs` | Aspect: bundle of values/behaviours for Apply/Discard |
| `SceneEntityAspect<T>` | `Scripts/Aspects/SceneEntityAspect`1.cs` | MonoBehaviour aspect: `Apply` / `Discard` (e.g. enemy aggro in trigger zone) |
| `ScriptableEntityAspect<T>` | `Scripts/Aspects/ScriptableEntityAspect`1.cs` | SO aspect, shareable across many entities |
