# Atomic Framework — Elements (quick lookup)

> **Base path:** `Assets/Plugins/Atomic/Elements/`
> See also: [atomic-elements-full.md](atomic-elements-full.md) (exhaustive index)

---

## Frequently Used Components

| Component | Path | Purpose |
|-----------|------|---------|
| `IReactiveVariable<T>` | `Scripts/Variables/Reactive/IReactiveVariable.cs` | Reactive variable contract with `OnEvent` on change |
| `ReactiveVariable<T>` | `Scripts/Variables/Reactive/ReactiveVariable.cs` | Generic reactive variable |
| `ReactiveFloat` | `Scripts/Variables/Reactive/Common/ReactiveFloat.cs` | Reactive float — inventory, multipliers, progress |
| `ReactiveInt` | `Scripts/Variables/Reactive/Common/ReactiveInt.cs` | Reactive int |
| `ReactiveBool` | `Scripts/Variables/Reactive/Common/ReactiveBool.cs` | Reactive bool — state flags (`IsWorking`, `IsUnderConstruction`) |
| `ReactiveDictionary<TKey,TValue>` | `Scripts/Collections/Dictionary/ReactiveDictionary.cs` | Reactive dictionary with `OnItemAdded/Removed/Changed` |
| `ReactiveList<T>` | `Scripts/Collections/List/ReactiveList.cs` | Reactive list with mutation events |
| `Event` / `Event<T>` | `Scripts/Events/Event.cs` | Fire-and-forget signal stored as entity value |
| `ISignal` / `ISignal<T>` | `Scripts/Events/ISignal.cs` | Signal contract with `Subscribe`/`Unsubscribe` |
| `Cooldown` | `Scripts/Time/Cooldown/Cooldown.cs` | Fill-and-reset timer: production, construction, gather |
| `ICooldown` | `Scripts/Time/Cooldown/ICooldown.cs` | Cooldown contract: `Tick`, `IsCompleted`, `ResetTime`, `Progress` |
| `IAction` | `Scripts/Actions/IAction.cs` | Side-effect without return value (`Invoke()`) |
| `InlineAction` | `Scripts/Actions/Core/InlineAction.cs` | `Action` → `IAction` wrapper; stored on entity |
| `CompositeAction` | `Scripts/Actions/Core/CompositeAction.cs` | Sequential execution of multiple `IAction` |
| `IFunction<T,R>` | `Scripts/Functions/IFunction.cs` | Pure function returning a value (query/compute) |
| `InlineFunction<T,R>` | `Scripts/Functions/InlineFunction.cs` | Delegate → `IFunction`; stored on entity |
| `IPredicate<T>` | `Scripts/Functions/IPredicate.cs` | Predicate `bool Invoke(T)` — condition |
| `AndPredicate` / `OrPredicate` / `NotPredicate` | `Scripts/Functions/AndPredicate.cs` etc. | Predicate composition (AND/OR/NOT) |
| `ICommand` | `Scripts/Command/ICommand.cs` | Action + conditions: `CanInvoke()` → `Invoke()` + `OnEvent` |
| `Command` | `Scripts/Command/Command.cs` | Command impl: `AddCondition`, `AddAction` (multicast) |
| `IRequest` | `Scripts/Requests/IRequest.cs` | One-shot flag: `Invoke()` → `Required=true`, `Consume()` resets |
| `Request` | `Scripts/Requests/Request.cs` | Request impl (not HTTP — internal request flag) |
| `IVariable<T>` | `Scripts/Variables/Base/IVariable.cs` | Simple non-reactive variable |
| `IExpression<R>` | `Scripts/Expressions/IExpression.cs` | Evaluatable expression with `Evaluate()` |
| `InlineExpression` | `Scripts/Expressions/InlineExpression.cs` | Delegate → expression |
| `ISetter<T>` | `Scripts/Setters/ISetter.cs` | Set value (`Set(value)`) |
| `InlineSetter<T>` | `Scripts/Setters/InlineSetter.cs` | Delegate → setter |
| `SceneAction` | `Scripts/Actions/Unity/SceneAction.cs` | MonoBehaviour `IAction` wrapper for Inspector |
| `UpTimer` / `DownTimer` | `Scripts/Time/Timer/UpTimer.cs`, `DownTimer.cs` | Count-up / count-down timers |
| `Stopwatch` | `Scripts/Time/Stopwatch/Stopwatch.cs` | Stopwatch with start/stop/reset state |
| `TriggerEvents` | `Scripts/UnityComponents/TriggerEvents.cs` | MonoBehaviour: Unity trigger → `Event`/`Action` |
