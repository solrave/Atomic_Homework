---
version: 1.2.0
---

# Atomic Framework

> **Scope**: Atomic Framework (Entities, Elements, Events) — entity-state-behaviour pattern, typed API keys via source generation, scene installers, reactive state, lifecycle behaviours, flow primitives (Action/Command/Function/Request), and project-specific GameContext / GameEntity domains.
> **Load when**: authoring or reviewing IGameContext / IGameEntity code, registering values and behaviours in installers, subscribing to reactive state or Atomic events, choosing Atomic flow components, adding GameContextAPI / GameEntityAPI keys, debugging entity lifecycle or state access.
> **References**: `.unikit/memory/stack/references/atomic-entities-quickref.md` (quick lookup), `.unikit/memory/stack/references/atomic-entities-full.md` (exhaustive index), `.unikit/memory/stack/references/atomic-elements-quickref.md` (quick lookup), `.unikit/memory/stack/references/atomic-elements-full.md` (exhaustive index), `.unikit/memory/stack/references/atomic-events-full.md` (exhaustive index)
> **Upstream**: https://github.com/StarKRE22/Atomic — Docs/Entities/Manual.md, Docs/Elements/*/Manual.md, Docs/Events/Manual.md (synced against this repo's `main` branch)

---

## Core Concepts

Atomic Framework is a Unity/C# toolkit under `Assets/Plugins/Atomic/` with three main modules:

| Module | Namespace | Purpose |
|--------|-----------|---------|
| **Entities** | `Atomic.Entities` | Entity container — tags, typed values, behaviours, lifecycle, installers, worlds |
| **Elements** | `Atomic.Elements` | Reactive primitives — values, variables, collections, events, timers, cooldowns, actions, commands, requests |
| **Events** | `Atomic.Events` | Standalone typed event-bus module (available; project gameplay events prefer `Atomic.Elements.Event` on entity values) |

The core pattern is **Entity–State–Behaviour**:

- **State** — typed data attached to an entity via generated accessor methods (`Add{Name}` / `Get{Name}` / `Set{Name}`)
- **Tags** — lightweight categorization (`Add{Name}Tag` / `Has{Name}Tag`)
- **Behaviours** — modular logic implementing lifecycle interfaces (`IEntityInit`, `IEntityTick`, etc., or their domain-typed equivalents)

Prefer small, composable behaviours over monolithic entity classes. Gameplay rules belong in behaviours or static use cases — not in entity subclasses.

**Data abstraction rule**: always work with data through reference-type wrappers (`IValue<T>` / `IVariable<T>`), never through raw fields. This removes tight coupling to storage and simplifies testing and multiplayer.

- `IValue<T>` — read-only wrapper (`Value { get; }`). Use for constants (`Const<T>`, `ScriptableConst<T>`) or read-only projections of externally-owned data.
- `IVariable<T>` — extends `IValue<T>`, adds a setter (`Value { get; set; }`). Use for mutable entity state (`Variable<T>`, `ReactiveVariable<T>`, `InlineVariable<T>`).
- Reactive versions (`IReactiveValue<T>`, `IReactiveVariable<T>`) add an `OnEvent` change notification.

---

## Component Lookup Workflow

When a task requires an Atomic Framework component and you are unsure which type to use:

1. **Identify the module** — `Entities` (entity container/lifecycle), `Elements` (reactive state + flow), or `Events` (standalone bus; rarely used in this project).
2. **Open the quickref first** — search `atomic-entities-quickref.md` or `atomic-elements-quickref.md` for a matching component by name or purpose.
3. **If not found in quickref** — open the corresponding `*-full.md` exhaustive index and search there.
4. **For Events module only** — use `atomic-events-full.md` (no quickref; full catalog only).
5. **Do not guess** — verify component name and file path against the reference table before recommending usage.

Path prefix for all tables: `Assets/Plugins/Atomic/{Module}/`.

---

## Project Entity Domains

This project defines two entity domains built on Atomic's **Entity API Source Generation** (`[EntityExtensionsAPI]`) and **Entity Domain Behaviours** generation (`[EntityDomainBehaviours(typeof(...))]`):

| Domain | Interface | Singleton | Installer base | API class |
|--------|-----------|-----------|----------------|-----------|
| Scene context | `IGameContext` | `GameContext : SceneEntitySingleton<GameContext>` | `GameContextInstaller` | `GameContextAPI` |
| Game objects | `IGameEntity` | per-instance | `GameEntityInstaller` | `GameEntityAPI` |

Domain declaration (once per domain, drives generation of `IGameContextInit`, `IGameContextTick`, `IGameContextEnable`, etc.):

```csharp
public interface IGameContext : IEntity { }

[EntityDomainBehaviours(typeof(IGameContext))]
public static class GameContextDomain { }
```

The generator produces `I{Domain}Behaviour`, `I{Domain}Init`, `I{Domain}Tick`, `I{Domain}FixedTick`, `I{Domain}Enable`, `I{Domain}Disable`, `I{Domain}Dispose`, etc. — do not hand-write these interfaces.

**Access the scene context** via `GameContext.Instance` (null-check in `OnEnable` / at call site).

**Folder layout** (per Atomic best practices, already used in this project):

```
Gameplay/
├── GameContext/          # scene singleton context
│   ├── Installer/        # SceneGameContextInstaller, TechInstaller
│   └── Controllers/      # IGameContext* behaviours
└── GameEntities/
    ├── Core/             # reusable mechanics (ProductionBehaviour, etc.)
    ├── View/             # presenters, visual binding
    └── Content/          # concrete building logic, SceneBuildingInstaller
```

Mechanics live in the domain they belong to. Do not put building production logic in GameContext controllers.

---

## Typed API Keys (Entity API Source Generation)

Never use magic strings, raw `int` keys, or generic key lookups for entity state. Declare keys in a `static partial class` decorated with `[EntityExtensionsAPI]`; a Roslyn source generator turns each field into strongly-typed extension methods at compile time — this runs automatically on every compile, no manual build step:

```csharp
// GameContextAPI.cs
[EntityExtensionsAPI]
public static partial class GameContextAPI
{
    public static readonly ValueKey<IGameContext, ReactiveDictionary<ResourceSO, ReactiveFloat>> InventoryItems =
        new(nameof(InventoryItems));
}

// GameEntityAPI.cs
[EntityExtensionsAPI]
public static partial class GameEntityAPI
{
    public static readonly TagKey<IGameEntity> Building = new(nameof(Building));
    public static readonly ValueKey<IGameEntity, Cooldown> ProductionTimer = new(nameof(ProductionTimer));
}
```

| Field type | Generated as |
|---|---|
| `TagKey<E>` | Tag methods extending `E` (e.g. `Add{Name}Tag`, `Has{Name}Tag`, `Del{Name}Tag`) |
| `TagKey` | Tag methods extending `IEntity` |
| `ValueKey<E, T>` | Value methods of type `T` extending `E` |
| `ValueKey<T>` | Value methods of type `T` extending `IEntity` |

After compilation the generator produces concrete, named methods — not a generic `GetValue(key)` accessor:

```csharp
entity.AddBuildingTag();
bool isBuilding = entity.HasBuildingTag();

entity.AddProductionTimer(new Cooldown(timeToProduce, 0f));
Cooldown timer = entity.GetProductionTimer();
entity.SetProductionTimer(newCooldown);

context.AddInventoryItems(new ReactiveDictionary<ResourceSO, ReactiveFloat>());
var inventory = context.GetInventoryItems();
```

### Rules

- Add new context state to `GameContextAPI` (partial class, grouped by feature with comments).
- Add new entity state/tags to `GameEntityAPI`.
- Every key field must be initialized with `new(nameof(FieldName))` — the **Entity API Analyzer** enforces this (`EAPI0001`: missing initializer, `EAPI0002`: initialized with `new()`/`default`), with a code fix available.
- Do not hand-edit generated extension methods or the generated `IGameContext` / `IGameEntity` domain-behaviour interfaces — they regenerate from the source classes on every compile.
- Prefer the generated `Add{Name}` / `Get{Name}` / `Set{Name}` / `Has{Name}Tag` methods over any raw/generic key lookup — they are what the framework and analyzer are built around.

### Value access

```csharp
// Required value — generated getter throws if missing
var inventory = context.GetInventoryItems();

// Optional value — prefer in behaviours and UI (generated TryGet)
if (entity.TryGetIsWorking(out var isWorking) && isWorking.Value)
    ...

// Existence check before access (UI OnEnable)
if (_context == null || !_context.HasInventoryItems())
    return;
```

Use the plain `Get{Name}` accessor only when the value is guaranteed to exist (registered in installer). Use `TryGet{Name}` / `Has{Name}` for optional or externally owned state.

---

## Installers

Installers wire state and behaviours onto entities at creation time. Base types: `IEntityInstaller` / `IEntityInstaller<E>` (plain interface), `MonoEntityInstaller` / `MonoEntityInstaller<E>` (scene-bound MonoBehaviour), `ScriptableEntityInstaller<E>` (reusable ScriptableObject). Every installer implements a single `Install(E entity)` method.

### Scene context installer

`SceneGameContextInstaller : GameContextInstaller` is the composition root for gameplay state:

```csharp
public override void Install(IGameContext entity)
{
    entity.AddBuildings(new ReactiveDictionary<Vector2Int, IGameEntity>());
    entity.AddOnBuildingChanged(new Atomic.Elements.Event<IGameEntity>());
    entity.AddBehaviour<BuildController>();
    entity.OnInitialized += () => { /* post-init setup */ };
}
```

- Register all shared reactive state here (or delegated sub-installers like `TechInstaller`).
- Register context controllers with `entity.AddBehaviour<T>()`.
- Use `entity.OnInitialized` for setup that depends on all values being registered.
- Set `[DefaultExecutionOrder(-1001)]` on the scene installer so context is ready before dependents.

### Entity installers

Prefab/scene entities use `GameEntityInstaller` subclasses (a `MonoEntityInstaller<IGameEntity>` specialization). Attach the script to a GameObject and drag it into the entity's **Scene Installers** field:

```csharp
public override void Install(IGameEntity entity)
{
    entity.AddSpriteRenderer(spriteRenderer);
    entity.OnInitialized += TryRegisterInGrid;
}
```

Building logic aspects (`ProductionLogicInstaller`, etc.) implement `Apply` / `Discard` (see Aspects below) — mirror every `Add{Name}` + `AddBehaviour` in `Discard` with `Del{Name}` + `DelBehaviour`.

### Sub-installer pattern

Extract feature registration into plain classes (not MonoBehaviour) when `SceneGameContextInstaller` grows:

```csharp
public sealed class TechInstaller
{
    public void Install(IGameContext entity, TechRepository repo) { ... }
}
```

---

## Aspects

An **Entity Aspect** (`IEntityAspect` / `IEntityAspect<E>`) applies or discards tags, values, and behaviours on an existing entity — a declarative way to extend/modify an entity at runtime (buffs, temporary states, trigger-zone effects), as opposed to installers which configure an entity once at creation.

```csharp
public sealed class SpeedBuffAspect : IEntityAspect<IGameEntity>
{
    public void Apply(IGameEntity entity) =>
        entity.SetMoveSpeed(entity.GetMoveSpeed() * 2f);

    public void Discard(IGameEntity entity) =>
        entity.SetMoveSpeed(entity.GetMoveSpeed() / 2f);
}
```

Three implementation styles: interface-based (`IEntityAspect`), MonoBehaviour-based (scene-bound), and ScriptableObject-based (reusable/shareable — good fit for the flyweight pattern across many entities). Always implement `Discard` as the exact inverse of `Apply` to avoid leaks.

---

## Lifecycle Behaviours

Behaviours are plain C# classes implementing typed lifecycle markers. Base (non-domain) interfaces: `IEntityInit`, `IEntityTick`, `IEntityFixedTick`, `IEntityEnable`, `IEntityDisable`, `IEntityDispose`. This project uses the domain-typed equivalents generated by `[EntityDomainBehaviours]`:

| Marker | When invoked | Project usage |
|--------|--------------|---------------|
| `IGameContextInit` / `IGameEntityInit` | Entity initialized | Cache values, subscribe to events |
| `IGameContextEnable` / `Disable` | Enable/disable cycle | Pause/resume without dispose |
| `IGameContextTick` / `IGameEntityFixedTick` | Per-frame / fixed update | Input, simulation, production |
| `IGameContextDispose` / `IGameEntityDispose` | Entity destroyed | Unsubscribe, release resources |

```csharp
public sealed class SynergyController : IGameContextInit, IGameContextDispose
{
    public void Init(IGameContext entity)
    {
        entity.GetOnBuildingChanged().Subscribe(OnBuildingChanged);
    }

    public void Dispose(IGameContext entity)
    {
        entity.GetOnBuildingChanged().Unsubscribe(OnBuildingChanged);
    }
}
```

### Rules

- Register behaviours in the installer — `entity.AddBehaviour<T>()`, not `new` in random places.
- Pair every `Subscribe` in `Init` with `Unsubscribe` in `Dispose` (same delegate reference), or store and dispose the returned `Subscription` object.
- Controllers that need per-frame logic implement `IGameContextTick` — do not use `MonoBehaviour.Update` for context-level gameplay.
- Entity behaviours (`ProductionBehaviour`) may read `GameContext.Instance` inside `FixedTick` when they need global state — pass `IGameContext` as parameter when the caller already has it.

---

## Reactive State (Atomic Elements)

### ReactiveVariable

Use for single observable values:

```csharp
entity.AddSelectedBuilding(new ReactiveVariable<BuildingInfo>(null));
entity.AddProductionMultiplier(new ReactiveFloat(1f));
```

- Assign via `.Value` — fires `OnEvent` only when value actually changes.
- Subscribe via `reactive.Subscribe(handler)` (returns a disposable `Subscription`) or the raw `OnEvent +=` delegate for UI binding.
- Expose as `IReactiveVariable<T>` in API keys when consumers should not replace the instance.
- For hot paths, prefer the specialized non-generic-comparer variants (`ReactiveFloat`, `ReactiveInt`, `ReactiveBool`, `ReactiveVector3`, …) over generic `ReactiveVariable<T>` — they skip `EqualityComparer<T>` and are faster.

### ReactiveDictionary / ReactiveList

Use for collections that drive UI or cross-entity reactions:

```csharp
var inventory = context.GetInventoryItems();
inventory.OnItemAdded += OnItemAdded;
inventory.OnItemRemoved += OnItemRemoved;
```

- Subscribe to `OnItemAdded`, `OnItemRemoved`, `OnItemChanged`, `OnStateChanged` as needed.
- Unsubscribe all handlers in `OnDisable` / `Dispose`.
- Nested reactivity: dictionary values can themselves be reactive (`ReactiveDictionary<ResourceSO, ReactiveFloat>`).

### Event / Signal

`Atomic.Elements.Event` / `Event<T1..T4>` implement the `ISignal` family and are used as fire-and-forget signals stored as entity values:

```csharp
context.GetOnBuildingChanged().Invoke(changedEntity);
```

```csharp
IEvent playerDiedEvent = new Event();
playerDiedEvent.OnEvent += () => Console.WriteLine("Player died");

Subscription sub = playerDiedEvent.Subscribe(() => Debug.Log("..."));
sub.Dispose(); // unsubscribe
```

- Implement `IEntityInit` + `IEntityDispose` listeners; subscribe via `.Subscribe(handler)` (returns `Subscription`, dispose to unsubscribe) or the raw `OnEvent +=` / `-=` delegate.
- Prefer context-level events for cross-cutting notifications (building changed, tech completed).
- Prefer entity-level `Event` values for local notifications (production completed, deposit refilled).
- This is distinct from the standalone `Atomic.Events` bus module (typed global bus with `Bus`/`Keys`/`Subscriptions`) — this project prefers entity-scoped `Atomic.Elements.Event` values for traceability; reach for `Atomic.Events` only for truly global, entity-independent signals.

### Cooldown / Timer

Both live in `Atomic.Elements` (Time module) and expose `Tick(deltaTime)`, `IsCompleted()`, `SetProgress(float)`, and `OnTimeChanged` / `OnProgressChanged` / `OnCompleted` events.

```csharp
entity.AddProductionTimer(new Cooldown(timeToProduce, 0f));
// In behaviour:
var timer = entity.GetProductionTimer();
timer.Tick(deltaTime);
if (timer.IsCompleted())
    timer.ResetTime();
```

- **`Cooldown`** — simple countdown, `ResetTime()` restarts it. Use for repeating fill-and-reset gameplay cycles (production, gather, ability cooldowns).
- **`Timer`** (`UpTimer` / `DownTimer`) — richer lifecycle: requires an explicit `Start()`, supports `Pause()` / `Resume()` / `Stop()`, fires `OnStarted`. Use when the mechanic needs start/pause/stop control, not just repeat-on-reset.

---

## Flow Primitives (Atomic Elements)

Atomic Elements provides composable flow types for entity-bound logic. These are alternatives to embedding guards directly inside static methods.

```
IFunction / IPredicate  ──conditions──►  Command  ──action──►  IAction
                                              │
Event / ISignal  ◄──── OnEvent ──────────────┘

IRequest    = deferred flag (Invoke → Consume(out value))
IExpression = Evaluate()
ISetter     = Set(value)
```

| Primitive | Role | When to use |
|-----------|------|-------------|
| `IAction` / `InlineAction` | Side effect (`Invoke`) | Entity-bound callback; store as value on entity |
| `IFunction` / `InlineFunction` | Query with return value | Compute/read without mutation |
| `IPredicate` | `bool` condition | Guards, filters; compose with `AndPredicate`/`OrPredicate` |
| `Command` / `Command<T>` | `CanInvoke()` + `TryInvoke()` + `OnEvent` | Player interaction boundary: same guard for UI preview and click |
| `Event<T>` | Fire-and-forget signal | Cross-cutting notifications on context/entity |
| `Request` / `Request<T>` | Deferred, dedup'd action | "Do once on next tick" without a permanent subscription |
| `IExpression` | Evaluatable expression | Composable numeric/bool logic (less mature; tests commented in plugin) |

### Command pattern

```csharp
ICommand<IGameEntity> fireCommand = new Command<IGameEntity>();
fireCommand
    .AddCondition(e => UnitUseCase.CanFire(context, e))
    .AddAction(e => FireUseCase.Fire(context, e));

entity.AddFireCommand(fireCommand);
// Controller: bool fired = fireCommand.TryInvoke(target);
// UI preview:  bool canFire = fireCommand.CanInvoke(target);
```

`Command` is semantically equivalent to manual `Can*` / `Try*` pairs already used in static use cases — but as a composable object shareable between highlight, UI, and click handlers. `TryInvoke` checks conditions and runs the action in one call, returning success; `CanInvoke` checks without side effects (drive button enabled/disabled state with it).

### Request pattern

```csharp
IRequest<GameObject> attackRequest = new Request<GameObject>();

// Input phase (e.g. Tick)
attackRequest.Invoke(targetObject);

// Processing phase (e.g. FixedTick)
if (attackRequest.Consume(out GameObject target))
{
    // execute the deferred action exactly once
}
```

Use `Request` instead of a raw bool flag when you need to defer an action from input-time to simulation-time while guaranteeing it fires at most once.

### Use Cases vs Command vs Behaviour

| Layer | Responsibility | Prefer when |
|-------|----------------|-------------|
| **Static use case** | Stateless domain rules | Internal logic, unit tests, batch/tick operations |
| **Command on entity/context** | Guard + action entry point | Player-facing interaction; preview must match click |
| **Behaviour** | Per-entity tick and lifecycle | Continuous simulation, event reaction |

Do not replace all static use cases with `Command` — that is over-engineering. Keep use cases as rule implementations; expose `Command` only at interaction boundaries where guard reuse matters.

---

## Use Cases vs Behaviours

| Layer | Responsibility | Access pattern |
|-------|----------------|----------------|
| **Behaviour** | Per-entity tick, lifecycle, event reaction | `IGameEntity` / `IGameContext` param |
| **Use case** | Stateless gameplay operations | `static` methods with `IGameContext` first param |
| **Presenter (UI)** | Bind reactive state to views | `GameContext.Instance`, subscribe in `OnEnable` |

```csharp
// Use case — stateless operation
public static bool TryPlace(IGameContext context, BuildingInfo data, Vector2Int gridPos)

// Behaviour — per-entity tick
public void FixedTick(IGameEntity entity, float deltaTime)
```

Do not put business rules in `MonoBehaviour` UI classes — call use cases from UI event handlers.

---

## UI Binding Pattern

Presenters read context state and subscribe to reactive collections:

```csharp
private void OnEnable()
{
    _context = GameContext.Instance;
    if (_context == null || !_context.HasInventoryItems()) return;

    _inventory = _context.GetInventoryItems();
    _inventory.OnItemAdded += OnItemAdded;
    _inventory.OnItemRemoved += OnItemRemoved;
    foreach (var kv in _inventory) TryBind(kv.Key, kv.Value);
}

private void OnDisable()
{
    if (_inventory != null)
    {
        _inventory.OnItemAdded -= OnItemAdded;
        _inventory.OnItemRemoved -= OnItemRemoved;
    }
    // Unsubscribe nested ReactiveFloat.OnEvent handlers
}
```

Track per-item `OnEvent` handlers in a dictionary so they can be removed on item removal.

---

## InlineAction / InlineFunction

Use for entity-bound delegates without dedicated behaviour classes:

```csharp
entity.AddOnBuildingChanged(new InlineAction());
entity.AddGetImpactPositions(new InlineFunction<IEnumerable<Vector2Int>>(...));
```

Prefer dedicated `Event` or behaviour classes when logic grows beyond a one-liner.

---

## Anti-patterns

- **Magic string keys** — `entity.GetValue<int>("health")` instead of generated `Get{Name}()` accessors from a `[EntityExtensionsAPI]` class.
- **Missing unsubscribe** — subscribing in `Init` without `Unsubscribe` in `Dispose` / `OnDisable`, or discarding the `Subscription` returned by `.Subscribe(...)` without disposing it.
- **MonoBehaviour.Update for context logic** — use `IGameContextTick` behaviours registered in installer.
- **Direct dictionary mutation bypassing use cases** — e.g. adding buildings without going through placement use cases (skips validation, events, synergy).
- **Storing `IGameContext` in static fields** — use `GameContext.Instance` at point of use; do not cache globally beyond presenter lifetime.
- **Subclassing `Entity` for gameplay types** — use `IGameEntity` + values/tags/behaviours; project uses interfaces generated by `[EntityDomainBehaviours]`.
- **Registering values in behaviours** — values belong in installers; behaviours read and react.
- **Forgetting `Discard` symmetry** — aspect `Discard` must undo everything `Apply` registers (mirror every `Add{Name}` + `AddBehaviour` with `Del{Name}` + `DelBehaviour`).
- **Using `Atomic.Events` bus when an entity value event suffices** — prefer `Atomic.Elements.Event<T>` on context/entity for typed, traceable signals.
- **Guessing Atomic component names** — always verify against quickref first, then full index (see Component Lookup Workflow).
- **Replacing static use cases with Command everywhere** — use Command only at interaction boundaries; keep domain rules in use cases.
- **Confusing `Cooldown` and `Timer`** — use `Cooldown` for simple repeat-on-reset cycles, `Timer` (`UpTimer`/`DownTimer`) when start/pause/stop control is needed.
- **Using `IValue<T>` where mutation is required, or exposing `IVariable<T>` where callers should only read** — pick the narrowest interface that matches the actual read/write need.
