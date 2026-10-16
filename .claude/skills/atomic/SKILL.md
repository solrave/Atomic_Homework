---
name: atomic
description: Atomic Framework 2.0 (Entities, Elements) reference for this Unity top-down zombie shooter. Use when writing or reviewing IGameEntity / IGameContext code, SceneEntity prefabs, SceneEntityInstaller installers, entity values/tags/behaviours, .atomic Entity API files, Entity Domain Generator output, reactive state (IValue, IVariable, ReactiveInt/ReactiveVector3), Event/Subscription, Cooldown/Timer, Command/Request, aspects, MVP presenters over entity state, or debugging entity lifecycle.
---

# Atomic Framework

> **Scope**: Atomic Framework 2.0.0 (`Assets/Plugins/Atomic/`, modules Entities + Elements) — entity-state-behaviour pattern, typed API generated from `.atomic` files, scene entities and installers, reactive state, lifecycle behaviours, flow primitives (Action/Command/Function/Request), and this project's GameEntity / GameContext domains.
> **Load when**: authoring or reviewing gameplay code for the shooter (character, zombies, weapons, bullets, pickups, trigger zones, kill counter), registering values and behaviours in installers, editing `.atomic` API files, subscribing to reactive state or events, choosing Atomic flow components, writing UI presenters, debugging entity lifecycle or state access.
> **References**: `references/atomic-entities-quickref.md` (quick lookup), `references/atomic-entities-full.md` (exhaustive index), `references/atomic-elements-quickref.md` (quick lookup), `references/atomic-elements-full.md` (exhaustive index)
> **Upstream**: https://github.com/StarKRE22/Atomic — plugin version **2.0.0** (`Assets/Plugins/Atomic/package.json`). Upstream docs may describe APIs (`[EntityAPI]` / `[EntityExtensionsAPI]` source-generator attributes, `Atomic.Events`) that are **not** in this version — always verify against the plugin sources.
> **Game spec**: `HomeworkObjectives/Homework.docx` (same text as `AtomicMD/Homework.pdf`).

---

## Core Concepts

Atomic Framework is a Unity/C# toolkit under `Assets/Plugins/Atomic/` with two modules:

| Module | Namespace | Purpose |
|--------|-----------|---------|
| **Entities** | `Atomic.Entities` | Entity container — tags, typed values, behaviours, lifecycle, installers, aspects, worlds, codegen tools |
| **Elements** | `Atomic.Elements` | Reactive primitives — values, variables, collections, events, timers, cooldowns, actions, commands, requests |

There is **no** `Atomic.Events`, `Atomic.Contexts` or `Atomic.Presenters` module in this version. "Contexts" from the game spec are implemented as a scene-singleton entity domain (`GameContext`); presenters are plain C# / MonoBehaviour MVP classes.

The core pattern is **Entity–State–Behaviour**:

- **State** — typed data attached to an entity via generated accessor methods (`Add{Name}` / `Get{Name}` / `Set{Name}`)
- **Tags** — lightweight categorization (`Add{Name}Tag` / `Has{Name}Tag`)
- **Behaviours** — modular logic implementing lifecycle interfaces (`IEntityInit`, `IEntityTick`, …, or their domain-typed equivalents)

Prefer small, composable behaviours over monolithic entity classes. Gameplay rules belong in behaviours or static use cases — not in entity subclasses or MonoBehaviours. The spec grades: procedural style, separation of data and logic, reusable mechanics, SOLID, MVP.

**Data abstraction rule**: always work with data through reference-type wrappers (`IValue<T>` / `IVariable<T>`), never through raw fields. This removes tight coupling to storage and simplifies testing.

- `IValue<T>` — read-only wrapper (`Value { get; }`). Use for constants (`Const<T>`, `ScriptableConst<T>`) or read-only projections of externally-owned data.
- `IVariable<T>` — extends `IValue<T>`, adds a setter. Use for mutable entity state (`Variable<T>`, `ReactiveVariable<T>`, `InlineVariable<T>`).
- Reactive versions (`IReactiveValue<T>`, `IReactiveVariable<T>`) are also `ISignal<T>` — they expose `OnEvent` change notification.

---

## Component Lookup Workflow

When a task requires an Atomic component and you are unsure which type to use:

1. **Identify the module** — `Entities` (entity container/lifecycle/codegen) or `Elements` (reactive state + flow).
2. **Open the quickref first** — search `atomic-entities-quickref.md` or `atomic-elements-quickref.md`.
3. **If not found in quickref** — open the corresponding `*-full.md` exhaustive index.
4. **Do not guess** — verify the type and its members in `Assets/Plugins/Atomic/{Module}/Scripts/` before recommending usage. Names from upstream docs or other projects may not exist here (e.g. `AndPredicate`, `Command.TryInvoke`, `MonoEntityInstaller`).

Path prefix for all tables: `Assets/Plugins/Atomic/{Module}/`.

---

## Project Entity Domains

> **Status**: gameplay code is not written yet. This section is the **target convention** derived from the spec's "Архитектура игры" section. Update it with real class names once the domains are generated.

| Domain | Spec term | Interface | Concrete (mode) | Lives on | API file |
|--------|-----------|-----------|-----------------|----------|----------|
| Game objects | Atomic.Entities | `IGameEntity` | `GameEntity : SceneEntity` | Character, Enemy, Bullet, Pistol, Hand, AmmoItem, HealthItem prefabs | `GameEntityAPI.atomic` |
| Game systems | Atomic.Contexts | `IGameContext` | `GameContext : SceneEntitySingleton<GameContext>` | `[Context]` object in `GameScene` | `GameContextAPI.atomic` |

### Generating a domain

Use **`Window/Atomic/Entities/Entity Domain Generator`** (`Entities/Editor/EntityDomain/EntityDomainWindow.cs`). Settings per domain:

- **Entity Type**: `GameEntity` / `GameContext`; **Mode**: `SceneEntity` / `SceneEntitySingleton`
- **Namespace**: `Game`; **Directory**: `Assets/Game/Scripts/GameEntities/` or `Assets/Game/Scripts/GameContext/`
- **Installers**: `SceneEntityInstaller` (add `ScriptableEntityInstaller` if data-driven configs are needed)
- Optional: `SceneEntityProxy` (for colliders on child objects → resolve the owning entity in triggers/raycasts), `SceneEntityWorld`, aspects, pools/factories (bullets)

The generator writes: the interface (`IGameEntity : IEntity`), the concrete class, domain behaviour interfaces `IGameEntityInit`, `IGameEntityEnable`, `IGameEntityDisable`, `IGameEntityDispose`, `IGameEntityTick`, `IGameEntityFixedTick`, `IGameEntityLateTick`, `IGameEntityGizmos` (file `{Type}Behaviours.cs`), and installer base classes. These are generated files — regenerate instead of hand-editing. Verify exact names after generation.

**Access the scene context** via `GameContext.Instance` (lazy `FindObjectsByType`, may be null before the scene is loaded — null-check at call site / in `OnEnable`). Prefer passing `IGameContext` explicitly into use cases.

### Folder layout (target)

```
Assets/Game/Scripts/
├── APIKeys/              # GameEntityAPI.atomic, GameContextAPI.atomic + generated *.cs
├── GameContext/          # IGameContext domain (generated) 
│   ├── Installers/       # GameContextInstaller (KillCount, Character ref, input)
│   └── Systems/          # IGameContext* behaviours: InputSystem, KillCounter, EnemyTriggerZone logic
├── GameEntities/         # IGameEntity domain (generated)
│   ├── Common/           # reusable mechanics: Health, Death, Movement, Rotation/Aim, Weapon, Pickup, Lifetime
│   ├── Character/        # CharacterInstaller
│   ├── Enemy/            # ZombieInstaller, target-chasing behaviour
│   ├── Weapons/          # PistolInstaller (ranged, bullets, ammo), HandInstaller (melee OverlapSphere)
│   ├── Bullet/           # BulletInstaller
│   ├── Items/            # HealthItemInstaller, AmmoItemInstaller
│   └── View/             # Animator binding (IsMoving, Attack, TakeDamage, Death, "fire_event"), audio, VFX
└── UI/                   # HealthScreenView, StatView (existing) + Presenters/ (MVP)
```

Mechanics live in the domain they belong to: per-object mechanics (health, movement, shooting) in `GameEntities/Common`; scene-wide rules (input, kill counter, trigger zones) in `GameContext/Systems`.

---

## Typed Entity API (`.atomic` files)

Never use magic strings, raw `int` keys, or generic `GetValue<T>(key)` lookups in gameplay code. Declare tags and values in a `.atomic` YAML file; the editor generator (`Entities/Editor/EntityAPI/`) turns it into a static class of extension methods.

```yaml
# Assets/Game/Scripts/APIKeys/GameEntityAPI.atomic
namespace: Game
className: GameEntityAPI
directory: Assets/Game/Scripts/APIKeys/
aggressiveInlining: true
unsafe: false
entityType: IGameEntity

imports:
  - UnityEngine
  - Atomic.Elements

tags:
  - Character
  - Enemy
  - Dead

values:
  # Common
  - Transform: Transform
  # Health
  - Health: ReactiveInt
  - MaxHealth: IValue<int>
  - TakeDamageEvent: Event<int>
  # Movement / Aim
  - MoveSpeed: IValue<float>
  - MoveDirection: ReactiveVector3
  - AimDirection: ReactiveVector3
  # Weapon
  - Ammo: ReactiveInt
  - FireCooldown: Cooldown
  - FireCommand: Command
  - AttackRequest: Request
```

- **Generate**: `Tools/Atomic/Entities/Compile Entity API`; auto-refresh is on by default (`EntityAPISettings.autoRefresh`, `Tools/Atomic/Entities/Select Entity API Settings`). **Create** a new file: `Assets/Create/Atomic/Entities/Entity API`.
- **Generated methods** (see `EntityAPIGenerator.cs`):
  - tags: `Has{Tag}Tag`, `Add{Tag}Tag`, `Del{Tag}Tag`
  - values: `Get{Value}`, `Ref{Value}`, `TryGet{Value}(out)`, `Add{Value}`, `Has{Value}`, `Del{Value}`, `Set{Value}`
- The existing `Assets/Game/Scripts/APIKeys/EntityAPI.atomic` (className `AtomicAPIExtensions`, `entityType: IEntity`) is an empty placeholder — rename/repoint it to `GameEntityAPI` / `IGameEntity` once the domain exists, and add `GameContextAPI.atomic` for `IGameContext`.
- The generated class stores keys as `public static readonly int` ids resolved via `EntityNames.NameToId(nameof(...))` (`Entities/Scripts/Names/`).
- `ValueKey<T>` / `ValueKey<E,T>` / `TagKey` / `TagKey<E>` structs (`Entities/Scripts/Names/`) also exist for hand-written typed keys with `AddValue(key, value)` — but in this project prefer the `.atomic` generator; there is **no** attribute-driven source generator in 2.0.0 (`Scripts/Codegen/EntityAPIAttribute.cs` is commented out).
- Group keys by feature with comments; keep the `.atomic` file as the single source of truth. Do not hand-edit generated `*.cs`.

### Value access

```csharp
// Required value — throws if missing; use when the installer guarantees it
ReactiveInt health = entity.GetHealth();

// Optional value — prefer in reusable behaviours, triggers, UI
if (other.TryGetHealth(out ReactiveInt targetHealth)) ...

// Tag checks
if (entity.HasDeadTag()) return;
```

---

## Installers

Installers wire state and behaviours onto entities at creation time. Base types (`Entities/Scripts/Installers/`): `IEntityInstaller` / `IEntityInstaller<E>`, `SceneEntityInstaller` / `SceneEntityInstaller<E>` (MonoBehaviour), `ScriptableEntityInstaller` / `ScriptableEntityInstaller<E>` (ScriptableObject). Each has `Install(E entity)` and a virtual `Uninstall(E entity)`.

A `SceneEntity` collects installers from its **Scene Installers** (`sceneInstallers`, auto-filled from children on Reset) and **Scriptable Installers** lists; `installOnAwake` and `useUnityLifecycle` are on by default, so the entity installs and ticks itself.

### Entity installer

```csharp
public sealed class CharacterInstaller : SceneEntityInstaller<IGameEntity>
{
    [SerializeField] private Transform _transform;
    [SerializeField] private int _maxHealth = 10;
    [SerializeField] private float _moveSpeed = 5f;

    public override void Install(IGameEntity entity)
    {
        entity.AddCharacterTag();
        entity.AddTransform(_transform);
        entity.AddHealth(new ReactiveInt(_maxHealth));
        entity.AddMaxHealth(new Const<int>(_maxHealth));
        entity.AddMoveSpeed(new Const<float>(_moveSpeed));
        entity.AddMoveDirection(new ReactiveVector3());
        entity.AddTakeDamageEvent(new Event<int>());

        entity.AddBehaviour<MoveBehaviour>();
        entity.AddBehaviour<DeathBehaviour>();
    }
}
```

- Tune numbers from the spec via serialized fields or `ScriptableConst<T>` / `ScriptableEntityInstaller` — not hard-coded in behaviours.
- Shared mechanics (health + death + movement) used by both Character and Zombie → extract a reusable installer (e.g. `HealthInstaller`, `MovementInstaller`) and add it to both prefabs.

### Context installer

```csharp
public sealed class GameContextInstaller : SceneEntityInstaller<IGameContext>
{
    [SerializeField] private GameEntity _character;

    public override void Install(IGameContext context)
    {
        context.AddCharacter(_character);
        context.AddKillCount(new ReactiveInt());
        context.AddBehaviour<KillCounterSystem>();
    }
}
```

- Register all shared/scene-wide state here (or in sub-installers).
- Use `entity.OnInitialized` for setup that depends on all values being registered.
- If other entities read context state during their own install/init, ensure the context initializes first (`[DefaultExecutionOrder]` on the context or explicit ordering).

---

## Aspects

An **Entity Aspect** (`IEntityAspect<E>`, `SceneEntityAspect<E>`, `ScriptableEntityAspect<E>`) applies or discards tags/values/behaviours on an existing entity at runtime — buffs, temporary states, trigger-zone effects — as opposed to installers, which configure an entity once at creation.

```csharp
// Enemy trigger zone: character enters → zombies chase/attack; exits → back to Idle
public sealed class EnemyAggroAspect : SceneEntityAspect<IGameEntity>
{
    public override void Apply(IGameEntity enemy) =>
        enemy.AddBehaviour<ChaseTargetBehaviour>();

    public override void Discard(IGameEntity enemy) =>
        enemy.DelBehaviour<ChaseTargetBehaviour>();
}
```

Always implement `Discard` as the exact inverse of `Apply` (mirror every `Add{Name}` / `AddBehaviour` with `Del{Name}` / `DelBehaviour`).

---

## Lifecycle Behaviours

Behaviours are plain C# classes implementing lifecycle markers. Base interfaces (`Entities/Scripts/Behaviours/`): `IEntityInit`, `IEntityEnable`, `IEntityDisable`, `IEntityTick`, `IEntityFixedTick`, `IEntityLateTick`, `IEntityDispose`, `IEntityGizmos` (and generic `IEntityXxx<E>`). This project uses the domain-typed ones (`IGameEntityInit`, `IGameContextTick`, …).

| Marker | Signature | Typical usage |
|--------|-----------|---------------|
| `*Init` | `Init(E entity)` | Cache values, subscribe to events |
| `*Enable` / `*Disable` | `Enable(E)` / `Disable(E)` | Pause/resume without dispose |
| `*Tick` / `*FixedTick` / `*LateTick` | `Tick(E entity, float deltaTime)` | Input, movement, cooldowns, AI |
| `*Dispose` | `Dispose(E entity)` | Unsubscribe, release resources |

```csharp
public sealed class DeathBehaviour : IGameEntityInit, IGameEntityDispose
{
    private IGameEntity _entity;
    private Subscription<int> _subscription;

    public void Init(IGameEntity entity)
    {
        _entity = entity;
        _subscription = entity.GetHealth().Subscribe(OnHealthChanged);
    }

    public void Dispose(IGameEntity entity) => _subscription.Dispose();

    private void OnHealthChanged(int health)
    {
        if (health <= 0 && !_entity.HasDeadTag())
            _entity.AddDeadTag();
    }
}

public sealed class MoveBehaviour : IGameEntityFixedTick
{
    public void FixedTick(IGameEntity entity, float deltaTime)
    {
        if (entity.HasDeadTag()) return; // dead cannot move / aim / attack
        Vector3 direction = entity.GetMoveDirection().Value;
        entity.GetTransform().position += direction * (entity.GetMoveSpeed().Value * deltaTime);
    }
}
```

### Rules

- Register behaviours in installers — `entity.AddBehaviour<T>()` (requires `new()`), not `new` in random places.
- Pair every subscription in `Init` with disposal/unsubscription in `Dispose` (store the `Subscription`, or use the same delegate with `OnEvent -=`).
- Per-frame gameplay uses `*Tick` / `*FixedTick` behaviours, not `MonoBehaviour.Update`.
- The "dead" rule is shared: every movement/aim/attack behaviour guards on the `Dead` tag (or a shared predicate) rather than each reimplementing it.

---

## Reactive State (Atomic Elements)

### ReactiveVariable

```csharp
entity.AddHealth(new ReactiveInt(10));
entity.AddAimDirection(new ReactiveVector3());
entity.AddTarget(new ReactiveVariable<IGameEntity>());
```

- Assign via `.Value` — fires `OnEvent` only when the value actually changes.
- Subscribe via `.Subscribe(handler)` (returns a disposable `Subscription<T>`) or raw `OnEvent +=`.
- Expose as `IReactiveVariable<T>` / `IReactiveValue<T>` in API keys when consumers should not replace the instance.
- Prefer specialized types (`ReactiveInt`, `ReactiveFloat`, `ReactiveBool`, `ReactiveVector2`, `ReactiveVector3`, `ReactiveQuaternion`, …) over `ReactiveVariable<T>` for primitives.

### ReactiveList / ReactiveDictionary

Use for collections that drive UI or cross-entity reactions (e.g. list of enemies in a trigger zone). Subscribe to `OnItemAdded`, `OnItemRemoved`, `OnItemChanged`, `OnStateChanged`; unsubscribe all handlers in `Dispose` / `OnDisable`.

### Event / Signal

`Atomic.Elements.Event` / `Event<T1..T4>` (`Elements/Scripts/Events/`) implement `ISignal` and are stored as entity values:

```csharp
entity.GetTakeDamageEvent().Invoke(damage);           // fire
var sub = entity.GetTakeDamageEvent().Subscribe(PlayTakeDamageAnimation);
sub.Dispose();                                        // unsubscribe
```

- Entity-level events for local notifications (took damage, died, fired, picked up).
- Context-level events for cross-cutting notifications (enemy killed → kill counter).

### Cooldown / Timer

Both live in `Atomic.Elements` (`Elements/Scripts/Time/`).

```csharp
entity.AddFireCooldown(new Cooldown(1f));     // pistol / hand: 1 s
// In behaviour:
var cooldown = entity.GetFireCooldown();
cooldown.Tick(deltaTime);
if (cooldown.IsCompleted()) { /* fire */ cooldown.ResetTime(); }
```

- **`Cooldown`** — countdown with `Tick`, `IsCompleted()`, `ResetTime()`, `GetProgress()`/`SetProgress()`. Use for repeating gameplay cycles: weapon cooldowns, first-shot aim delay (0.5 s), bullet lifetime (3 s).
- **`DownTimer` / `UpTimer`** — explicit `Start()` / `Pause()` / `Resume()` / `Stop()`. Use when the mechanic needs start/stop control.

---

## Flow Primitives (Atomic Elements)

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
| `IAction` / `InlineAction` | Side effect (`Invoke`) | Entity-bound callback stored as a value |
| `IFunction` / `InlineFunction` | Query with return value | Compute/read without mutation |
| `IPredicate` / `InlinePredicate` | `bool` condition | Guards, filters |
| `Command` / `Command<T>` | `CanInvoke()` + guarded `Invoke()` + `OnEvent` | Same guard for preview and execution |
| `Event<T>` | Fire-and-forget signal | Notifications on context/entity |
| `Request` / `Request<T>` | Deferred, dedup'd action | "Do once on next tick" (input → simulation, animation event → shot) |
| `IExpression` | Evaluatable expression | Composable numeric/bool logic |

### Command pattern

```csharp
var fireCommand = new Command();
fireCommand
    .AddCondition(() => !weapon.HasDeadTag())
    .AddCondition(() => weapon.GetAmmo().Value > 0)
    .AddCondition(() => weapon.GetFireCooldown().IsCompleted());
fireCommand.AddAction(() => FireUseCase.Fire(weapon));

weapon.AddFireCommand(fireCommand);
// Behaviour: command.Invoke();      // checks conditions itself, no-op if any fails
// UI/AI:     command.CanInvoke();   // check without side effects
```

There is **no `TryInvoke`** in this version: `Invoke()` silently returns when a condition fails; call `CanInvoke()` first if you need to know whether it ran.

### Request pattern

```csharp
// Input / animation phase: right joystick held, or "fire_event" from Animator
entity.GetAttackRequest().Invoke();

// Processing phase (Tick/FixedTick)
if (entity.GetAttackRequest().Consume())
    entity.GetFireCommand().Invoke();
```

Use `Request` instead of a raw bool flag when an action must be deferred and fire at most once.

### Unity event bridges

`Elements/Scripts/UnityComponents/` has MonoBehaviours that turn Unity callbacks into Atomic events — prefer them over custom `OnTriggerEnter` MonoBehaviours with logic inside:

- `TriggerEvents` — `OnTriggerEnter/Exit` → event: pickups (Health/Ammo item), enemy trigger zones.
- `CollisionEvents` — collisions: bullet hits.
- `AnimationEvents` — Animator event callbacks: the `"fire_event"` in Character/Zombie attack animations.

Register the component as an entity value in the installer and subscribe in an `*Init` behaviour (unsubscribe in `*Dispose`). Check the exact event members in the source before use.

---

## Use Cases vs Command vs Behaviour

| Layer | Responsibility | Prefer when |
|-------|----------------|-------------|
| **Static use case** | Stateless domain rules (`DamageUseCase.TakeDamage(target, damage)`, `HealUseCase.Heal(target, 3)`, `AmmoUseCase.Add(weapon, 10)`) | Shared rules, unit tests |
| **Command on entity** | Guard + action entry point | Same guard needed in several places |
| **Behaviour** | Per-entity tick and lifecycle | Continuous simulation, event reaction |
| **Presenter (UI)** | Bind reactive state to views | MVP layer, no rules |

Do not replace all use cases with `Command` — keep rules in use cases, expose `Command` only where guard reuse matters. Bullets, hands and pickups all call the same `DamageUseCase` / `HealUseCase` — do not duplicate damage logic per weapon.

---

## UI Binding Pattern (MVP)

Views are dumb MonoBehaviours (existing: `Assets/Game/Scripts/UI/StatView.cs` — `SetText`, `SetProgress`, `SetVisible`; `HealthScreenView.cs` — `ChangePercent`, `TakeDamage`). Presenters subscribe to entity/context state and push it into views:

```csharp
public sealed class HealthPresenter : IDisposable
{
    private readonly StatView _view;
    private readonly IGameEntity _character;
    private readonly Subscription<int> _subscription;

    public HealthPresenter(StatView view, IGameEntity character)
    {
        _view = view;
        _character = character;
        _subscription = character.GetHealth().Subscribe(OnHealthChanged);
        OnHealthChanged(character.GetHealth().Value);
    }

    private void OnHealthChanged(int health)
    {
        int max = _character.GetMaxHealth().Value;
        _view.SetText(health.ToString());
        _view.SetProgress((float) health / max);
    }

    public void Dispose() => _subscription.Dispose();
}
```

Same shape for ammo (`StatView`), kill counter (context `KillCount`) and `HealthScreenView` (percent + `TakeDamageEvent`). No gameplay rules in views or presenters.

---

## InlineAction / InlineFunction

Use for entity-bound delegates without dedicated behaviour classes:

```csharp
entity.AddIsAlive(new InlineFunction<bool>(() => !entity.HasDeadTag()));
```

Prefer dedicated `Event` or behaviour classes when logic grows beyond a one-liner.

---

## Anti-patterns

- **Magic keys** — `entity.GetValue<int>(someInt)` instead of generated `Get{Name}()` from a `.atomic` file.
- **Using APIs from upstream docs/other projects** — `[EntityExtensionsAPI]` / `[EntityDomainBehaviours]` attributes, `MonoEntityInstaller`, `Atomic.Events`, `Command.TryInvoke`, `AndPredicate` do not exist in 2.0.0.
- **Hand-editing generated files** — `*API.cs`, `IGameEntity*` behaviour interfaces; edit the `.atomic` file or regenerate the domain instead.
- **Missing unsubscribe** — subscribing in `Init` without disposing in `Dispose` / `OnDisable`.
- **MonoBehaviour.Update for gameplay** — use `*Tick` behaviours registered in installers.
- **Gameplay logic in views** — `HealthScreenView` / `StatView` only display; presenters bind; behaviours/use cases decide.
- **Duplicated mechanics** — separate health/death/movement code for Character and Zombie; extract to `GameEntities/Common` and reuse.
- **Ignoring the Dead state** — every move/aim/attack mechanic must stop when the entity is dead.
- **Storing `IGameContext` in static fields** — use `GameContext.Instance` at the point of use or pass it as a parameter.
- **Subclassing `Entity`/`SceneEntity` for gameplay types** — use `IGameEntity` + values/tags/behaviours.
- **Registering values in behaviours** — values belong in installers (or aspects); behaviours read and react.
- **Forgetting `Discard` symmetry** — aspect `Discard` must undo everything `Apply` adds.
- **Guessing Atomic component names** — verify against quickref, then full index, then source.
- **Confusing `Cooldown` and `Timer`** — `Cooldown` for repeat-on-reset cycles, `DownTimer`/`UpTimer` when start/pause/stop is needed.
- **Wrong interface width** — don't use `IValue<T>` where mutation is required, or expose `IVariable<T>` where callers should only read.
