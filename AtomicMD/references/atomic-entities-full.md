# Atomic Framework — Entities (exhaustive index)

> **Base path:** `Assets/Plugins/Atomic/Entities/` · Namespace: `Atomic.Entities`
> See also: [atomic-entities-quickref.md](atomic-entities-quickref.md) (quick lookup)
---

## Entities — Core

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntity` | `Scripts/Entities/Interface/IEntity.cs` | Базовый интерфейс: values, tags, behaviours, lifecycle, `OnStateChanged` |
| `IEntity_Values` | `Scripts/Entities/Interface/IEntity_Values.cs` | Контракт key-value state |
| `IEntity_Tags` | `Scripts/Entities/Interface/IEntity_Tags.cs` | Контракт системы тегов |
| `IEntity_Behaviours` | `Scripts/Entities/Interface/IEntity_Behaviours.cs` | Контракт behaviours |
| `Entity` | `Scripts/Entities/Core/Entity.cs` | Чистая C#-реализация `IEntity` |
| `Entity_Values` | `Scripts/Entities/Core/Entity_Values.cs` | Partial: реализация values |
| `Entity_Tags` | `Scripts/Entities/Core/Entity_Tags.cs` | Partial: реализация tags |
| `Entity_Behaviours` | `Scripts/Entities/Core/Entity_Behaviours.cs` | Partial: реализация behaviours |
| `Entity_Lifecycle` | `Scripts/Entities/Core/Entity_Lifecycle.cs` | Partial: init/enable/tick/dispose |
| `Entity_Debug` | `Scripts/Entities/Core/Entity_Debug.cs` | Partial: debug-утилиты |
| `Extensions` | `Scripts/Entities/Extensions.cs` | Общие extension-методы для `IEntity` |
| `Extensions_Values` | `Scripts/Entities/Extensions_Values.cs` | `AddValue`, `GetValue`, `TryGetValue`, `SetValue`, `DelValue` |
| `Extensions_Tags` | `Scripts/Entities/Extensions_Tags.cs` | `AddTag`, `HasTag`, `DelTag` |
| `Extensions_Behaviours` | `Scripts/Entities/Extensions_Behaviours.cs` | `AddBehaviour`, `GetBehaviour`, `HasBehaviour`, `DelBehaviour` |

## Entities — Unity (Scene)

| Component | Path | Purpose |
|-----------|------|------------|
| `SceneEntity` | `Scripts/Entities/Unity/SceneEntity.cs` | MonoBehaviour-entity на сцене/prefab |
| `SceneEntitySingleton<T>` | `Scripts/Entities/Unity/SceneEntitySingleton.cs` | Singleton entity (`Instance`) |
| `SceneEntityProxy` | `Scripts/Entities/Unity/SceneEntityProxy.cs` | Прокси к другому entity |
| `SceneEntityProxy<T>` | `Scripts/Entities/Unity/SceneEntityProxy`1.cs` | Типизированный прокси |
| `SceneEntity_Values` | `Scripts/Entities/Unity/SceneEntity_Values.cs` | Partial: values на MonoBehaviour |
| `SceneEntity_Tags` | `Scripts/Entities/Unity/SceneEntity_Tags.cs` | Partial: tags |
| `SceneEntity_Behaviours` | `Scripts/Entities/Unity/SceneEntity_Behaviours.cs` | Partial: behaviours |
| `SceneEntity_Lifecycle` | `Scripts/Entities/Unity/SceneEntity_Lifecycle.cs` | Partial: Unity lifecycle hooks |
| `SceneEntity_Installing` | `Scripts/Entities/Unity/SceneEntity_Installing.cs` | Partial: вызов installer |
| `SceneEntity_Registration` | `Scripts/Entities/Unity/SceneEntity_Registration.cs` | Partial: регистрация в world |
| `SceneEntity_Destruction` | `Scripts/Entities/Unity/SceneEntity_Destruction.cs` | Partial: destroy/cleanup |
| `SceneEntity_Casting` | `Scripts/Entities/Unity/SceneEntity_Casting.cs` | Partial: cast к типизированному интерфейсу |
| `SceneEntity_Gizmos` | `Scripts/Entities/Unity/SceneEntity_Gizmos.cs` | Partial: editor gizmos |
| `SceneEntity_Inspector` | `Scripts/Entities/Unity/SceneEntity_Inspector.cs` | Partial: Odin/custom inspector |
| `SceneEntity_Editor` | `Scripts/Entities/Unity/SceneEntity_Editor.cs` | Partial: editor-only |
| `SceneEntity_Debug` | `Scripts/Entities/Unity/SceneEntity_Debug.cs` | Partial: debug |
| `SceneEntity_Unity` | `Scripts/Entities/Unity/SceneEntity_Unity.cs` | Partial: Unity callbacks |

## Keys — Typed Keys

| Component | Path | Purpose |
|-----------|------|------------|
| `ValueKey` | `Scripts/Keys/Keys/ValueKey.cs` | Untyped value key (int hash) |
| `ValueKey<TEntity,TValue>` | `Scripts/Keys/Keys/ValueKey'1.cs` | Типизированный ключ state |
| `TagKey` | `Scripts/Keys/Keys/TagKey.cs` | Untyped tag key |
| `TagKey<TEntity>` | `Scripts/Keys/Keys/TagKey'1.cs` | Типизированный ключ тега |
| `EntityKeyStore` | `Scripts/Keys/EntityKeyStore.cs` | Реестр ключей, алгоритм хеширования |
| `IEntityKeyAlgorithm` | `Scripts/Keys/Algorithms/IEntityKeyAlgorithm.cs` | Контракт алгоритма генерации int-ключей |
| `Fnv1AEntityKeyAlgorithm` | `Scripts/Keys/Algorithms/Fnv1AEntityKeyAlgorithm.cs` | FNV-1a хеш для ключей |
| `SequentialEntityKeyAlgorithm` | `Scripts/Keys/Algorithms/SequentialEntityKeyAlgorithm.cs` | Последовательные int-ключи |
| `SHA256EntityKeyAlgorithm` | `Scripts/Keys/Algorithms/SHA256EntityKeyAlgorithm.cs` | SHA256-based ключи |
| `EntityAPIAttribute` | `Scripts/Keys/Attributes/EntityAPIAttribute.cs` | Атрибут API-класса домена |
| `ValueKeyAttribute` | `Scripts/Keys/Attributes/ValueKeyAttribute.cs` | Метаданные value key |
| `TagKeyAttribute` | `Scripts/Keys/Attributes/TagKeyAttribute.cs` | Метаданные tag key |

## Installers — composition root entity

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityInstaller` | `Scripts/Installers/IEntityInstaller.cs` | Контракт: `Install(IEntity)` |
| `IEntityInstaller<T>` | `Scripts/Installers/IEntityInstaller`1.cs` | Типизированный installer |
| `SceneEntityInstaller` | `Scripts/Installers/SceneEntityInstaller.cs` | MonoBehaviour installer (non-generic) |
| `SceneEntityInstaller<T>` | `Scripts/Installers/SceneEntityInstaller`1.cs` | MonoBehaviour installer для typed entity |
| `SceneEntityInstallerConfigurable` | `Scripts/Installers/SceneEntityInstallerConfigurable.cs` | Installer с конфигурируемыми аспектами |
| `ScriptableEntityInstaller` | `Scripts/Installers/ScriptableEntityInstaller.cs` | SO installer (non-generic) |
| `ScriptableEntityInstaller<T>` | `Scripts/Installers/ScriptableEntityInstaller`1.cs` | SO installer для typed entity |

## Behaviours — Lifecycle Markers

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityBehaviour` | `Scripts/Behaviours/IEntityBehaviour.cs` | Маркер behaviour |
| `IEntityInit` | `Scripts/Behaviours/IEntityInit.cs` | `Init(IEntity)` после регистрации |
| `IEntityEnable` | `Scripts/Behaviours/IEntityEnable.cs` | `Enable(IEntity)` |
| `IEntityDisable` | `Scripts/Behaviours/IEntityDisable.cs` | `Disable(IEntity)` |
| `IEntityTick` | `Scripts/Behaviours/IEntityTick.cs` | `Tick(IEntity, float deltaTime)` |
| `IEntityFixedTick` | `Scripts/Behaviours/IEntityFixedTick.cs` | `FixedTick(IEntity, float fixedDelta)` |
| `IEntityLateTick` | `Scripts/Behaviours/IEntityLateTick.cs` | `LateTick(IEntity, float deltaTime)` |
| `IEntityGizmos` | `Scripts/Behaviours/IEntityGizmos.cs` | `OnDrawGizmos(IEntity)` |
| `IEntityDispose` | `Scripts/Behaviours/IEntityDispose.cs` | `Dispose(IEntity)` — cleanup |
| `EditModeBehaviourAttribute` | `Scripts/Behaviours/Attributes/EditModeBehaviourAttribute.cs` | Запуск behaviour в Edit Mode |

## Lifecycle — Phase Dispatch

| Component | Path | Purpose |
|-----------|------|------------|
| `IInitLifecycle` | `Scripts/Lifecycle/Sources/IInitLifecycle.cs` | Контракт init-фазы |
| `IEnableLifecycle` | `Scripts/Lifecycle/Sources/IEnableLifecycle.cs` | Контракт enable/disable |
| `ITickLifecycle` | `Scripts/Lifecycle/Sources/ITickLifecycle.cs` | Контракт tick-фаз |
| `IGizmosLifecycle` | `Scripts/Lifecycle/Sources/IGizmosLifecycle.cs` | Контракт gizmos |
| `TickManager` | `Scripts/Lifecycle/TickManager.cs` | Центральный tick-диспетчер |
| `InitSubscription` | `Scripts/Lifecycle/Subscriptions/InitSubscription.cs` | Подписка на init |
| `EnableSubscription` | `Scripts/Lifecycle/Subscriptions/EnableSubscription.cs` | Подписка на enable |
| `DisableSubscription` | `Scripts/Lifecycle/Subscriptions/DisableSubscription.cs` | Подписка на disable |
| `DisposeSubscription` | `Scripts/Lifecycle/Subscriptions/DisposeSubscription.cs` | Подписка на dispose |
| `TickSubscription` | `Scripts/Lifecycle/Subscriptions/TickSubscription.cs` | Подписка на tick |
| `FixedTickSubscription` | `Scripts/Lifecycle/Subscriptions/FixedTickSubscription.cs` | Подписка на fixed tick |
| `LateTickSubscription` | `Scripts/Lifecycle/Subscriptions/LateTickSubscription.cs` | Подписка на late tick |
| `GizmosSubscription` | `Scripts/Lifecycle/Subscriptions/GizmosSubscription.cs` | Подписка на gizmos |
| `Extensions` | `Scripts/Lifecycle/Extensions.cs` | Extension-методы lifecycle |

## World — Entity Container

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityWorld` | `Scripts/World/Interface/IEntityWorld.cs` | Контракт мира entity |
| `IEntityWorld<T>` | `Scripts/World/Interface/IEntityWorld`1.cs` | Типизированный мир |
| `EntityWorld` | `Scripts/World/Core/EntityWorld.cs` | Чистая C#-реализация world |
| `EntityWorld<T>` | `Scripts/World/Core/EntityWorld`1.cs` | Типизированный world |
| `SceneEntityWorld` | `Scripts/World/Unity/SceneEntityWorld.cs` | MonoBehaviour world |
| `SceneEntityWorld<T>` | `Scripts/World/Unity/SceneEntityWorld`1.cs` | Типизированный scene world |
| `SceneEntityWorldSingleton` | `Scripts/World/Unity/SceneEntityWorldSingleton.cs` | Singleton world |
| `SceneEntityWorld_Inspector` | `Scripts/World/Unity/SceneEntityWorld_Inspector.cs` | Inspector partial |
| `SceneEntityWorld`1_Collection` | `Scripts/World/Unity/SceneEntityWorld`1_Collection.cs` | Partial: коллекция entity |
| `SceneEntityWorld`1_Lifecycle` | `Scripts/World/Unity/SceneEntityWorld`1_Lifecycle.cs` | Partial: lifecycle world |
| `SceneEntityWorld`1_Singleton` | `Scripts/World/Unity/SceneEntityWorld`1_Singleton.cs` | Partial: singleton |
| `SceneEntityWorld`1_Static` | `Scripts/World/Unity/SceneEntityWorld`1_Static.cs` | Partial: static API |
| `SceneEntityWorld`1_UnityCallbacks` | `Scripts/World/Unity/SceneEntityWorld`1_UnityCallbacks.cs` | Partial: Unity Update/FixedUpdate |
| `Extensions` | `Scripts/World/Extensions.cs` | Extension-методы world |

## Collections — Entity Collections

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityCollection` | `Scripts/Collections/IEntityCollection.cs` | Контракт коллекции |
| `IEntityCollection<T>` | `Scripts/Collections/IEntityCollection`1.cs` | Типизированная коллекция |
| `IReadOnlyEntityCollection` | `Scripts/Collections/IReadOnlyEntityCollection.cs` | Read-only контракт |
| `IReadOnlyEntityCollection<T>` | `Scripts/Collections/IReadOnlyEntityCollection`1.cs` | Read-only typed |
| `EntityCollection` | `Scripts/Collections/EntityCollection.cs` | Реализация коллекции |
| `EntityCollection<T>` | `Scripts/Collections/EntityCollection`1.cs` | Typed коллекция с событиями |
| `Extensions` | `Scripts/Collections/Extensions.cs` | Extension-методы коллекций |

## Filters — Entity Filtering

| Component | Path | Purpose |
|-----------|------|------------|
| `EntityFilter` | `Scripts/Filters/EntityFilter.cs` | Фильтр по triggers |
| `EntityFilter<T>` | `Scripts/Filters/EntityFilter`1.cs` | Typed фильтр |
| `DerivedEntityFilter` | `Scripts/Filters/DerivedEntityFilter.cs` | Фильтр-наследник |
| `DerivedEntityFilter<T>` | `Scripts/Filters/DerivedEntityFilter`1.cs` | Typed derived filter |
| `IEntityTrigger` | `Scripts/Filters/Triggers/IEntityTrigger.cs` | Контракт trigger-условия |
| `IEntityTrigger<T>` | `Scripts/Filters/Triggers/IEntityTrigger`1.cs` | Typed trigger |
| `InlineEntityTrigger` | `Scripts/Filters/Triggers/InlineEntityTrigger.cs` | Delegate → trigger |
| `InlineEntityTrigger<T>` | `Scripts/Filters/Triggers/InlineEntityTrigger`1.cs` | Typed inline trigger |
| `TagEntityTrigger` | `Scripts/Filters/Triggers/TagEntityTrigger.cs` | Trigger по тегу |
| `TagEntityTrigger<T>` | `Scripts/Filters/Triggers/TagEntityTrigger`1.cs` | Typed tag trigger |
| `ValueEntityTrigger` | `Scripts/Filters/Triggers/ValueEntityTrigger.cs` | Trigger по value |
| `ValueEntityTrigger<T>` | `Scripts/Filters/Triggers/ValueEntityTrigger`1.cs` | Typed value trigger |
| `BehaviourEntityTrigger` | `Scripts/Filters/Triggers/BehaviourEntityTrigger.cs` | Trigger по behaviour |
| `BehaviourEntityTrigger<T>` | `Scripts/Filters/Triggers/BehaviourEntityTrigger`1.cs` | Typed behaviour trigger |
| `StateChangedEntityTrigger` | `Scripts/Filters/Triggers/StateChangedEntityTrigger.cs` | Trigger при изменении state |
| `StateChangedEntityTrigger<T>` | `Scripts/Filters/Triggers/StateChangedEntityTrigger`1.cs` | Typed state trigger |

## Factories — Entity Creation

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityFactory` | `Scripts/Factories/Interfaces/IEntityFactory.cs` | Контракт фабрики |
| `IEntityFactory<T>` | `Scripts/Factories/Interfaces/IEntityFactory`1.cs` | Typed фабрика |
| `IMultiEntityFactory` | `Scripts/Factories/Interfaces/IMultiEntityFactory.cs` | Фабрика нескольких типов |
| `IMultiEntityFactory<T>` | `Scripts/Factories/Interfaces/IMultiEntityFactory`1.cs` | Typed multi-factory |
| `EntityFactory` | `Scripts/Factories/Unity/EntityFactory.cs` | Unity factory |
| `EntityFactory<T>` | `Scripts/Factories/Unity/EntityFactory`1.cs` | Instantiate + install |
| `EntityCatalog` | `Scripts/Factories/Unity/EntityCatalog.cs` | Каталог prefab → factory |
| `EntityCatalog<T>` | `Scripts/Factories/Unity/EntityCatalog`1.cs` | Typed каталог |

## Pooling — Entity Pools

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityPool` | `Scripts/Pooling/Interfaces/IEntityPool.cs` | Контракт пула |
| `IEntityPool<T>` | `Scripts/Pooling/Interfaces/IEntityPool`1.cs` | Typed пул |
| `IMultiEntityPool` | `Scripts/Pooling/Interfaces/IMultiEntityPool.cs` | Multi-type пул |
| `IMultiEntityPool<T>` | `Scripts/Pooling/Interfaces/IMultiEntityPool`1.cs` | Typed multi-pool |
| `IPrefabEntityPool` | `Scripts/Pooling/Interfaces/IPrefabEntityPool.cs` | Пул на prefab |
| `IPrefabEntityPool<T>` | `Scripts/Pooling/Interfaces/IPrefabEntityPool`1.cs` | Typed prefab pool |
| `EntityPool` | `Scripts/Pooling/Core/EntityPool.cs` | Базовый пул |
| `EntityPool<T>` | `Scripts/Pooling/Core/EntityPool`1.cs` | Typed пул |
| `MultiEntityPool` | `Scripts/Pooling/Core/MultiEntityPool.cs` | Multi-type пул |
| `MultiEntityPool<T>` | `Scripts/Pooling/Core/MultiEntityPool`1.cs` | Typed multi-pool |
| `PrefabEntityPool` | `Scripts/Pooling/Unity/PrefabEntityPool.cs` | Unity prefab pool |
| `PrefabEntityPool<T>` | `Scripts/Pooling/Unity/PrefabEntityPool`1.cs` | Typed prefab pool |
| `SceneEntityPool` | `Scripts/Pooling/Unity/SceneEntityPool.cs` | Scene-based pool |
| `SceneEntityPool<T>` | `Scripts/Pooling/Unity/SceneEntityPool`1.cs` | Typed scene pool |
| `Extensions` | `Scripts/Pooling/Extensions.cs` | Extension-методы пулов |

## Aspects — Logic Bundles

| Component | Path | Purpose |
|-----------|------|------------|
| `IEntityAspect` | `Scripts/Aspects/IEntityAspect.cs` | Контракт аспекта: Apply/Discard |
| `IEntityAspect<T>` | `Scripts/Aspects/IEntityAspect`1.cs` | Typed аспект |
| `SceneEntityAspect` | `Scripts/Aspects/SceneEntityAspect.cs` | MonoBehaviour аспект |
| `SceneEntityAspect<T>` | `Scripts/Aspects/SceneEntityAspect`1.cs` | Typed scene аспект |
| `ScriptableEntityAspect` | `Scripts/Aspects/ScriptableEntityAspect.cs` | SO аспект |
| `ScriptableEntityAspect<T>` | `Scripts/Aspects/ScriptableEntityAspect`1.cs` | Typed SO аспект |
| `Extensions` | `Scripts/Aspects/Extensions.cs` | Extension-методы аспектов |

## Systems — Entity Update Systems

| Component | Path | Purpose |
|-----------|------|------------|
| `EntitySystem` | `Scripts/Systems/EntitySystem.cs` | Система обновления entity |
| `EntitySystemBase` | `Scripts/Systems/EntitySystemBase.cs` | Базовый класс системы |
| `PriorityEntitySystem` | `Scripts/Systems/PriorityEntitySystem.cs` | Система с приоритетами |
| `EntityUpdater` | `Scripts/Systems/Updaters/EntityUpdater.cs` | Updater без приоритетов |
| `EntityUpdaterBase` | `Scripts/Systems/Updaters/EntityUpdaterBase.cs` | Базовый updater |
| `PriorityEntityUpdater` | `Scripts/Systems/Updaters/PriorityEntityUpdater.cs` | Updater с High/Mid/Low buckets |
| `EntityUpdatePriority` | `Scripts/Systems/Settings/EntityUpdatePriority.cs` | Enum приоритетов |
| `EntityUpdateSettings` | `Scripts/Systems/Settings/EntityUpdateSettings.cs` | Настройки update |
| `PriorityEntityUpdateSettings` | `Scripts/Systems/Settings/PriorityEntityUpdateSettings.cs` | Настройки priority update |

## UI — Entity View Layer

| Component | Path | Purpose |
|-----------|------|------------|
| `EntityView` | `Scripts/UI/View/EntityView.cs` | MonoBehaviour view для entity |
| `EntityView<T>` | `Scripts/UI/View/EntityView`1.cs` | Typed view |
| `EntityView`1_Gizmos` | `Scripts/UI/View/EntityView`1_Gizmos.cs` | Gizmos partial |
| `Extensions` | `Scripts/UI/View/Extensions.cs` | View extensions |
| `EntityCollectionView` | `Scripts/UI/Collection/EntityCollectionView.cs` | View для коллекции entity |
| `EntityCollectionView<T>` | `Scripts/UI/Collection/EntityCollectionView`1.cs` | Typed collection view |
| `EntityViewPool` | `Scripts/UI/Pool/EntityViewPool.cs` | Пул view |
| `EntityViewPool<T>` | `Scripts/UI/Pool/EntityViewPool`1.cs` | Typed view pool |
| `EntityViewCatalog` | `Scripts/UI/Catalog/EntityViewCatalog.cs` | Каталог view prefab |
| `EntityViewCatalog<T>` | `Scripts/UI/Catalog/EntityViewCatalog`1.cs` | Typed view catalog |
| `EntityWorldView` | `Scripts/UI/World/EntityWorldView.cs` | View всего world |
| `EntityWorldView<T>` | `Scripts/UI/World/EntityWorldView`1.cs` | Typed world view |
| `EntityWorldViewSingleton` | `Scripts/UI/World/EntityWorldViewSingleton.cs` | Singleton world view |
| `EntityWorldViewSingleton<T>` | `Scripts/UI/World/EntityWorldViewSingleton`1.cs` | Typed singleton |

## Baking — Editor Bake

| Component | Path | Purpose |
|-----------|------|------------|
| `EntityBaker` | `Scripts/Baking/EntityBaker.cs` | Bake scene entities |
| `EntityBaker<T>` | `Scripts/Baking/EntityBaker`1.cs` | Typed baker |
| `EntityBakerOptimized` | `Scripts/Baking/EntityBakerOptimized.cs` | Оптимизированный baker |
| `EntityBakerOptimized<T>` | `Scripts/Baking/EntityBakerOptimized`1.cs` | Typed optimized baker |
| `EntityBaker`1_Editor` | `Scripts/Baking/EntityBaker`1_Editor.cs` | Editor partial |
| `EntityBaker`1_Gizmos` | `Scripts/Baking/EntityBaker`1_Gizmos.cs` | Gizmos partial |
| `EntityBaker`1_Static` | `Scripts/Baking/EntityBaker`1_Static.cs` | Static partial |

## Codegen — Domain Generation

| Component | Path | Purpose |
|-----------|------|------------|
| `EntityDomainBuilder` | `Scripts/Codegen/EntityDomainBuilder.cs` | Editor: генерация typed domain |
| `EntityDomainBuilderGenerator` | `Scripts/Codegen/EntityDomainBuilderGenerator.cs` | Генератор кода домена |
| `EntityDomainSnapshot` | `Scripts/Codegen/EntityDomainSnapshot.cs` | Snapshot конфигурации домена |

## Bootstrap & Registry

| Component | Path | Purpose |
|-----------|------|------------|
| `SceneEntityBootstrap` | `Scripts/Bootstrap/SceneEntityBootstrap.cs` | Bootstrap сцены |
| `EntityRegistry` | `Scripts/Registry/EntityRegistry.cs` | Глобальный реестр entity |

## Utils

| Component | Path | Purpose |
|-----------|------|------------|
| `Args` | `Scripts/Utils/Args.cs` | Утилита аргументов |
| `InternalUtils` | `Scripts/Utils/InternalUtils.cs` | Внутренние утилиты |
