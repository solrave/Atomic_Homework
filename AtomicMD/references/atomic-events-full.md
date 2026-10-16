# Atomic Framework — Events (exhaustive index)

> **Base path:** `Assets/Plugins/Atomic/Events/` · Namespace: `Atomic.Events`
> Separate from `Atomic.Elements.Event` — global/scene event bus by int keys.
> In GuildBuilder gameplay, prefer `Atomic.Elements.Event<T>` on entity.

---

## Event Bus — runtime

| Component | Path | Purpose |
|-----------|------|---------|
| `IEventBus` | `Scripts/Bus/Runtime/IEventBus.cs` | Bus contract: `Subscribe`/`Unsubscribe`/`Invoke` by int key |
| `EventBus` | `Scripts/Bus/Runtime/EventBus.cs` | Event bus implementation |
| `ThreadSafeEventBus` | `Scripts/Bus/Runtime/ThreadSafeEventBus.cs` | Thread-safe event bus |
| `Extensions` | `Scripts/Bus/Runtime/Extensions.cs` | Bus extension methods |

## Event Bus — Unity scene

| Component | Path | Purpose |
|-----------|------|---------|
| `SceneEventBus` | `Scripts/Bus/Unity/SceneEventBus.cs` | MonoBehaviour event bus on scene |
| `SceneEventBusSingleton` | `Scripts/Bus/Unity/SceneEventBusSingleton.cs` | Singleton scene bus |
| `SceneEventBus_Debug` | `Scripts/Bus/Unity/SceneEventBus_Debug.cs` | Debug partial |

## Keys — typed event keys

| Component | Path | Purpose |
|-----------|------|---------|
| `EventKey` | `Scripts/Keys/Keys/EventKey.cs` | Untyped event key (int hash) |
| `EventKey<T>` | `Scripts/Keys/Keys/EventKey`1.cs` | Typed key with 1 generic |
| `EventKey<T1,T2>` | `Scripts/Keys/Keys/EventKey`2.cs` | Typed key with 2 generics |
| `EventKey<T1,T2,T3>` | `Scripts/Keys/Keys/EventKey`3.cs` | Typed key with 3 generics |
| `EventKeyStore` | `Scripts/Keys/EventKeyStore.cs` | Event key registry |
| `IEventKeyAlgorithm` | `Scripts/Keys/Algorithms/IEventKeyAlgorithm.cs` | Key hashing algorithm contract |
| `Fnv1AEventKeyAlgorithm` | `Scripts/Keys/Algorithms/Fnv1AEventKeyAlgorithm.cs` | FNV-1a for event keys |
| `SequentialEventKeyAlgorithm` | `Scripts/Keys/Algorithms/SequentialEventKeyAlgorithm.cs` | Sequential int keys |
| `SHA256EventKeyAlgorithm` | `Scripts/Keys/Algorithms/SHA256EventKeyAlgorithm.cs` | SHA256-based keys |

## Subscription — subscription handles

| Component | Path | Purpose |
|-----------|------|---------|
| `Subscription` | `Scripts/Subscription/Subscription.cs` | Parameterless subscription handle |
| `Subscription<T>` | `Scripts/Subscription/Subscription`1.cs` | Handle with 1 parameter |
| `Subscription<T1,T2>` | `Scripts/Subscription/Subscription`2.cs` | Handle with 2 parameters |
| `Subscription<T1,T2,T3>` | `Scripts/Subscription/Subscription`3.cs` | Handle with 3 parameters |
