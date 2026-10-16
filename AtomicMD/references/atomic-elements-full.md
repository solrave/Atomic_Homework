# Atomic Framework — Elements (exhaustive index)

> **Base path:** `Assets/Plugins/Atomic/Elements/` · Namespace: `Atomic.Elements`
> See also: [atomic-elements-quickref.md](atomic-elements-quickref.md) (quick lookup)

---

## Actions — side-effect (IAction)

| Component | Path | Purpose |
|-----------|------|------------|
| `IAction` | `Scripts/Actions/IAction.cs` | Контракт: `void Invoke()` (до 4 generic-параметров) |
| `ICompositeAction` | `Scripts/Actions/ICompositeAction.cs` | Контракт композитного action |
| `InlineAction` | `Scripts/Actions/Core/InlineAction.cs` | `Action` → `IAction` (implicit conversion) |
| `InlineAction<T>` | `Scripts/Actions/Core/InlineAction.cs` | Typed inline action |
| `CompositeAction` | `Scripts/Actions/Core/CompositeAction.cs` | Последовательный запуск `IAction[]` |
| `LogAction` | `Scripts/Actions/Core/LogAction.cs` | Debug: лог при invoke |
| `Extensions` | `Scripts/Actions/Extensions.cs` | Extension-методы actions |
| `SceneAction` | `Scripts/Actions/Unity/SceneAction.cs` | MonoBehaviour wrapper `IAction` |
| `SceneActionComposite` | `Scripts/Actions/Unity/SceneActionComposite.cs` | MonoBehaviour composite actions |
| `SceneActionConfigurable` | `Scripts/Actions/Unity/SceneActionConfigurable.cs` | Inspector-configurable action sequence |
| `SceneActionReference` | `Scripts/Actions/Unity/SceneActionReference.cs` | Ссылка на SceneAction |

## Command — conditions + action

| Component | Path | Purpose |
|-----------|------|------------|
| `ICommand` | `Scripts/Command/ICommand.cs` | `IAction` + `ISignal`: `CanInvoke()`, `AddCondition`, `AddAction` |
| `ICommand<T>` … `ICommand<T1,T2,T3,T4>` | `Scripts/Command/ICommand.cs` | Параметризованные command |
| `Command` | `Scripts/Command/Command.cs` | Реализация: AND conditions → action → `OnEvent` |
| `Command<T>` … `Command<T1,T2,T3,T4>` | `Scripts/Command/Command.cs` | Параметризованные реализации |
| `ThreadSafeCommand` | `Scripts/Command/ThreadSafeCommand.cs` | Thread-safe вариант с flush |
| `ThreadSafeCommand<T>` … | `Scripts/Command/ThreadSafeCommand.cs` | Typed thread-safe |
| `Extensions` | `Scripts/Command/Extensions.cs` | `AddCondition(IFunction)`, `AddAction(IAction)` |

## Functions — query / predicate (IFunction)

| Component | Path | Purpose |
|-----------|------|------------|
| `IFunction<R>` | `Scripts/Functions/IFunction.cs` | Функция без аргументов → результат |
| `IFunction<T,R>` … `IFunction<T1,T2,T3,T4,R>` | `Scripts/Functions/IFunction.cs` | Параметризованные функции |
| `IPredicate` / `IPredicate<T>` | `Scripts/Functions/IPredicate.cs` | Предикат `bool Invoke(...)` |
| `InlineFunction<R>` | `Scripts/Functions/InlineFunction.cs` | Delegate → `IFunction` |
| `InlineFunction<T,R>` … | `Scripts/Functions/InlineFunction.cs` | Typed inline function |
| `InlinePredicate` / `InlinePredicate<T>` | `Scripts/Functions/InlinePredicate.cs` | Delegate → predicate |
| `AndPredicate` | `Scripts/Functions/AndPredicate.cs` | AND двух предикатов |
| `OrPredicate` | `Scripts/Functions/OrPredicate.cs` | OR двух предикатов |
| `NotPredicate` | `Scripts/Functions/NotPredicate.cs` | NOT предиката |
| `Extensions` | `Scripts/Functions/Extensions.cs` | Extension-методы functions |

## Expressions — вычисляемые выражения

| Component | Path | Purpose |
|-----------|------|------------|
| `IExpression<R>` | `Scripts/Expressions/IExpression.cs` | `R Evaluate()` |
| `IExpression<T,R>` … | `Scripts/Expressions/IExpression.cs` | Параметризованные expressions |
| `ExpressionBase<R>` | `Scripts/Expressions/ExpressionBase.cs` | Базовый класс expression |
| `ExpressionBase<T,R>` … | `Scripts/Expressions/ExpressionBase.cs` | Typed base |
| `ExpressionMember` | `Scripts/Expressions/ExpressionMember.cs` | Узел expression-дерева |
| `InlineExpression<R>` | `Scripts/Expressions/InlineExpression.cs` | Delegate → expression |
| `AndExpression` | `Scripts/Expressions/AndExpression.cs` | AND выражений |
| `OrExpression` | `Scripts/Expressions/OrExpression.cs` | OR выражений |
| `IntSumExpression` | `Scripts/Expressions/IntSumExpression.cs` | Сумма int-выражений |
| `IntMulExpression` | `Scripts/Expressions/IntMulExpression.cs` | Произведение int |
| `FloatSumExpression` | `Scripts/Expressions/FloatSumExpression.cs` | Сумма float |
| `FloatMulExpression` | `Scripts/Expressions/FloatMulExpression.cs` | Произведение float |
| `Extensions` | `Scripts/Expressions/Extensions.cs` | Extension-методы expressions |

## Requests — one-shot флаги

| Component | Path | Purpose |
|-----------|------|------------|
| `IRequest` | `Scripts/Requests/IRequest.cs` | `Required`, `Invoke()`, `Consume()` |
| `IRequest<T>` … `IRequest<T1,T2,T3,T4>` | `Scripts/Requests/IRequest.cs` | Параметризованные requests |
| `Request` | `Scripts/Requests/Request.cs` | Реализация one-shot флага |
| `Request<T>` … `Request<T1,T2,T3,T4>` | `Scripts/Requests/Request.cs` | Typed реализации |
| `Extensions` | `Scripts/Requests/Extensions.cs` | Extension-методы requests |

## Events / Signals

| Component | Path | Purpose |
|-----------|------|------------|
| `ISignal` / `ISignal<T>` … | `Scripts/Events/ISignal.cs` | Контракт сигнала с подпиской |
| `IEvent` / `IEvent<T>` … | `Scripts/Events/IEvent.cs` | Контракт event (invoke + subscribe) |
| `Event` / `Event<T>` … | `Scripts/Events/Event.cs` | Реализация event, `Invoke()` → subscribers |
| `ThreadSafeEvent` | `Scripts/Events/ThreadSafeEvent.cs` | Thread-safe event |
| `InlineSignal` | `Scripts/Events/InlineSignal.cs` | Delegate → signal |
| `Subscription` | `Scripts/Events/Subscription.cs` | Handle подписки с dispose |
| `Extensions` | `Scripts/Events/Extensions.cs` | `Subscribe`/`Unsubscribe` extensions |

## Setters

| Component | Path | Purpose |
|-----------|------|------------|
| `ISetter<T>` | `Scripts/Setters/ISetter.cs` | `void Set(T value)` |
| `InlineSetter<T>` | `Scripts/Setters/InlineSetter.cs` | Delegate → setter |

## Variables — base (non-reactive)

| Component | Path | Purpose |
|-----------|------|------------|
| `IVariable<T>` | `Scripts/Variables/Base/IVariable.cs` | Контракт переменной `.Value` |
| `Variable<T>` | `Scripts/Variables/Base/Variable.cs` | Базовая реализация |
| `InlineVariable<T>` | `Scripts/Variables/Base/InlineVariable.cs` | Inline variable |
| `ThreadSafeVariable<T>` | `Scripts/Variables/Base/ThreadSafeVariable.cs` | Thread-safe variable |
| `BoolVariable` | `Scripts/Variables/Base/Common/BoolVariable.cs` | Bool variable |
| `IntVariable` | `Scripts/Variables/Base/Common/IntVariable.cs` | Int variable |
| `FloatVariable` | `Scripts/Variables/Base/Common/FloatVariable.cs` | Float variable |
| `Vector2Variable` | `Scripts/Variables/Base/Unity/Vector2Variable.cs` | Vector2 |
| `Vector2IntVariable` | `Scripts/Variables/Base/Unity/Vector2IntVariable.cs` | Vector2Int |
| `Vector3Variable` | `Scripts/Variables/Base/Unity/Vector3Variable.cs` | Vector3 |
| `Vector3IntVariable` | `Scripts/Variables/Base/Unity/Vector3IntVariable.cs` | Vector3Int |
| `Vector4Variable` | `Scripts/Variables/Base/Unity/Vector4Variable.cs` | Vector4 |
| `QuaternionVariable` | `Scripts/Variables/Base/Unity/QuaternionVariable.cs` | Quaternion |
| `float2_variable` … `float4_variable` | `Scripts/Variables/Base/Mathematics/` | Mathematics types |
| `int2_variable` … `int4_variable` | `Scripts/Variables/Base/Mathematics/` | Mathematics int types |
| `quaternion_variable` | `Scripts/Variables/Base/Mathematics/quaternion_variable.cs` | Mathematics quaternion |
| `Extensions` | `Scripts/Variables/Extensions.cs` | Variable extensions |

## Variables — reactive

| Component | Path | Purpose |
|-----------|------|------------|
| `IReactiveVariable<T>` | `Scripts/Variables/Reactive/IReactiveVariable.cs` | Reactive: `.Value` + `OnEvent` |
| `ReactiveVariable<T>` | `Scripts/Variables/Reactive/ReactiveVariable.cs` | Generic reactive variable |
| `InlineReactiveVariable<T>` | `Scripts/Variables/Reactive/InlineReactiveVariable.cs` | Inline reactive |
| `ThreadSafeReactiveVariable<T>` | `Scripts/Variables/Reactive/ThreadSafeReactiveVariable.cs` | Thread-safe reactive |
| `ReactiveBool` | `Scripts/Variables/Reactive/Common/ReactiveBool.cs` | Reactive bool |
| `ReactiveInt` | `Scripts/Variables/Reactive/Common/ReactiveInt.cs` | Reactive int |
| `ReactiveFloat` | `Scripts/Variables/Reactive/Common/ReactiveFloat.cs` | Reactive float |
| `ReactiveVector2` | `Scripts/Variables/Reactive/Unity/ReactiveVector2.cs` | Reactive Vector2 |
| `ReactiveVector2Int` | `Scripts/Variables/Reactive/Unity/ReactiveVector2Int.cs` | Reactive Vector2Int |
| `ReactiveVector3` | `Scripts/Variables/Reactive/Unity/ReactiveVector3.cs` | Reactive Vector3 |
| `ReactiveVector3Int` | `Scripts/Variables/Reactive/Unity/ReactiveVector3Int.cs` | Reactive Vector3Int |
| `ReactiveVector4` | `Scripts/Variables/Reactive/Unity/ReactiveVector4.cs` | Reactive Vector4 |
| `ReactiveQuaternion` | `Scripts/Variables/Reactive/Unity/ReactiveQuaternion.cs` | Reactive Quaternion |
| `reactive_float2` … `reactive_float4` | `Scripts/Variables/Reactive/Mathematics/` | Mathematics reactive |
| `reactive_int2` … `reactive_int4` | `Scripts/Variables/Reactive/Mathematics/` | Mathematics reactive int |
| `reactive_quaternion` | `Scripts/Variables/Reactive/Mathematics/reactive_quaternion.cs` | Reactive math quaternion |

## Variables — proxy (Unity bindings)

| Component | Path | Purpose |
|-----------|------|------------|
| `BoolPrefsVariable` | `Scripts/Variables/Proxy/PlayerPrefs/BoolPrefsVariable.cs` | PlayerPrefs bool |
| `IntPrefsVariable` | `Scripts/Variables/Proxy/PlayerPrefs/IntPrefsVariable.cs` | PlayerPrefs int |
| `FloatPrefsVariable` | `Scripts/Variables/Proxy/PlayerPrefs/FloatPrefsVariable.cs` | PlayerPrefs float |
| `StringPrefsVariable` | `Scripts/Variables/Proxy/PlayerPrefs/StringPrefsVariable.cs` | PlayerPrefs string |
| `TransformPositionVariable` | `Scripts/Variables/Proxy/Transform/TransformPositionVariable.cs` | Proxy Transform.position |
| `TransformRotationVariable` | `Scripts/Variables/Proxy/Transform/TransformRotationVariable.cs` | Proxy Transform.rotation |
| `TransformScaleVariable` | `Scripts/Variables/Proxy/Transform/TransformScaleVariable.cs` | Proxy Transform.localScale |
| `TransformParentVariable` | `Scripts/Variables/Proxy/Transform/TransformParentVariable.cs` | Proxy Transform.parent |
| `GameObjectLayerVariable` | `Scripts/Variables/Proxy/GameObject/GameObjectLayerVariable.cs` | Proxy GameObject.layer |

## Collections — reactive

| Component | Path | Purpose |
|-----------|------|------------|
| `IReactiveCollection` | `Scripts/Collections/IReactiveCollection.cs` | Базовый контракт reactive-коллекции |
| `IReadOnlyReactiveCollection` | `Scripts/Collections/IReadOnlyReactiveCollection.cs` | Read-only контракт |
| `IReactiveDictionary<TKey,TValue>` | `Scripts/Collections/Dictionary/IReactiveDictionary.cs` | Контракт reactive dictionary |
| `IReadOnlyReactiveDictionary` | `Scripts/Collections/Dictionary/IReadOnlyReactiveDictionary.cs` | Read-only dictionary |
| `ReactiveDictionary<TKey,TValue>` | `Scripts/Collections/Dictionary/ReactiveDictionary.cs` | Реализация: add/remove/change events |
| `ReactiveDictionary_KeyCollection` | `Scripts/Collections/Dictionary/ReactiveDictionary_KeyCollection.cs` | Key collection partial |
| `ReactiveDictionary_ValueCollection` | `Scripts/Collections/Dictionary/ReactiveDictionary_ValueCollection.cs` | Value collection partial |
| `ReactiveDictionary_Enumerator` | `Scripts/Collections/Dictionary/ReactiveDictionary_Enumerator.cs` | Enumerator partial |
| `ReactiveDictionary_Unity` | `Scripts/Collections/Dictionary/ReactiveDictionary_Unity.cs` | Unity serialization partial |
| `IReactiveList<T>` | `Scripts/Collections/List/IReactiveList.cs` | Контракт reactive list |
| `IReadOnlyReactiveList<T>` | `Scripts/Collections/List/IReadOnlyReactiveList.cs` | Read-only list |
| `ReactiveList<T>` | `Scripts/Collections/List/ReactiveList.cs` | Реализация reactive list |
| `ReactiveLinkedList<T>` | `Scripts/Collections/List/ReactiveLinkedList.cs` | Reactive linked list |
| `IReactiveSet<T>` | `Scripts/Collections/Set/IReactiveSet.cs` | Контракт reactive set |
| `ReactiveHashSet<T>` | `Scripts/Collections/Set/ReactiveHashSet.cs` | Reactive HashSet |
| `IReactiveArray<T>` | `Scripts/Collections/Array/IReactiveArray.cs` | Контракт reactive array |
| `IReadOnlyReactiveArray<T>` | `Scripts/Collections/Array/IReadOnlyReactiveArray.cs` | Read-only array |
| `IArray<T>` | `Scripts/Collections/Array/IArray.cs` | Базовый array контракт |
| `ReactiveArray<T>` | `Scripts/Collections/Array/ReactiveArray.cs` | Reactive array |
| `Extensions` | `Scripts/Collections/Extensions.cs` | Collection extensions |

## Values — const / inline

| Component | Path | Purpose |
|-----------|------|------------|
| `IValue<T>` | `Scripts/Values/IValue.cs` | Read-only value provider |
| `IReactiveValue<T>` | `Scripts/Values/IReactiveValue.cs` | Reactive value provider |
| `InlineValue<T>` | `Scripts/Values/InlineValue.cs` | Inline constant value |
| `Const<T>` | `Scripts/Values/Const.cs` | Immutable constant |
| `Constants` | `Scripts/Values/Constants.cs` | Набор predefined constants |
| `ScriptableConst<T>` | `Scripts/Values/ScriptableConst.cs` | SO constant |
| `Extensions` | `Scripts/Values/Extensions.cs` | Value extensions |

## Time — Cooldown

| Component | Path | Purpose |
|-----------|------|------------|
| `ICooldown` | `Scripts/Time/Cooldown/ICooldown.cs` | Контракт: Tick, Progress, IsCompleted, Reset |
| `Cooldown` | `Scripts/Time/Cooldown/Cooldown.cs` | Fill-and-reset таймер |
| `RandomCooldown` | `Scripts/Time/Cooldown/RandomCooldown.cs` | Cooldown со случайной длительностью |
| `ThreadSafeCooldown` | `Scripts/Time/Cooldown/ThreadSafeCooldown.cs` | Thread-safe cooldown |

## Time — Timer

| Component | Path | Purpose |
|-----------|------|------------|
| `ITimer` | `Scripts/Time/Timer/ITimer.cs` | Контракт таймера |
| `UpTimer` | `Scripts/Time/Timer/UpTimer.cs` | Таймер нарастания 0→duration |
| `DownTimer` | `Scripts/Time/Timer/DownTimer.cs` | Обратный отсчёт duration→0 |
| `TimerState` | `Scripts/Time/Timer/TimerState.cs` | Состояние таймера |

## Time — Stopwatch

| Component | Path | Purpose |
|-----------|------|------------|
| `IStopwatch` | `Scripts/Time/Stopwatch/IStopwatch.cs` | Контракт секундомера |
| `Stopwatch` | `Scripts/Time/Stopwatch/Stopwatch.cs` | Реализация stopwatch |
| `StopwatchState` | `Scripts/Time/Stopwatch/StopwatchState.cs` | Состояние stopwatch |

## Time — Period

| Component | Path | Purpose |
|-----------|------|------------|
| `IPeriod` | `Scripts/Time/Period/IPeriod.cs` | Контракт периодического интервала |
| `Period` | `Scripts/Time/Period/Period.cs` | Реализация period |
| `PeriodState` | `Scripts/Time/Period/PeriodState.cs` | Состояние period |

## Time — Timestamp

| Component | Path | Purpose |
|-----------|------|------------|
| `ITimestamp` | `Scripts/Time/Timestamp/ITimestamp.cs` | Контракт timestamp |
| `IDurationTimestamp` | `Scripts/Time/Timestamp/IDurationTimestamp.cs` | Timestamp с длительностью |
| `FixedTimestamp` | `Scripts/Time/Timestamp/FixedTimestamp.cs` | Фиксированный timestamp |
| `DurationTimestamp` | `Scripts/Time/Timestamp/DurationTimestamp.cs` | Timestamp + duration |
| `Extensions` | `Scripts/Time/Timestamp/Extensions.cs` | Timestamp extensions |

## Time — Sources (интерфейсы для time-модулей)

| Component | Path | Purpose |
|-----------|------|------------|
| `ITimeSource` | `Scripts/Time/Sources/ITimeSource.cs` | Источник времени |
| `ITickSource` | `Scripts/Time/Sources/ITickSource.cs` | Источник tick |
| `IStartSource` | `Scripts/Time/Sources/IStartSource.cs` | Источник start |
| `IPauseSource` | `Scripts/Time/Sources/IPauseSource.cs` | Источник pause |
| `IProgressSource` | `Scripts/Time/Sources/IProgressSource.cs` | Источник progress 0..1 |
| `ICompleteSource` | `Scripts/Time/Sources/ICompleteSource.cs` | Источник completion |
| `IStateSource` | `Scripts/Time/Sources/IStateSource.cs` | Источник state |
| `IDurationSource` | `Scripts/Time/Sources/IDurationSource.cs` | Источник duration |
| `Extensions` | `Scripts/Time/Extensions.cs` | Time extensions |

## UnityComponents — MonoBehaviour bridges

| Component | Path | Purpose |
|-----------|------|------------|
| `TriggerEvents` | `Scripts/UnityComponents/TriggerEvents.cs` | OnTriggerEnter/Exit → Event |
| `TriggerEvents2D` | `Scripts/UnityComponents/TriggerEvents2D.cs` | 2D trigger events |
| `CollisionEvents` | `Scripts/UnityComponents/CollisionEvents.cs` | OnCollision → Event |
| `CollisionEvents2D` | `Scripts/UnityComponents/CollisionEvents2D.cs` | 2D collision events |
| `AnimationEvents` | `Scripts/UnityComponents/AnimationEvents.cs` | Animation callbacks → Event |
| `RendererEvents` | `Scripts/UnityComponents/RendererEvents.cs` | Renderer visibility events |

## Utils

| Component | Path | Purpose |
|-----------|------|------------|
| `MainThreadDispatcher` | `Scripts/Utils/MainThreadDispatcher.cs` | Flush thread-safe ops на main thread |
| `AtomicUtils` | `Scripts/Utils/AtomicUtils.cs` | Общие утилиты |
| `InternalUtils` | `Scripts/Utils/InternalUtils.cs` | Внутренние утилиты |
| `Extensions` | `Scripts/Utils/Extensions.cs` | Utils extensions |
| `IRandomizer` | `Scripts/Utils/IRandomizer.cs` | Контракт random |
| `Optional<T>` | `Scripts/Utils/Optional.cs` | Optional value wrapper |
| `Reference<T>` | `Scripts/Utils/Reference.cs` | Mutable reference wrapper |
| `EqualityComparer` | `Scripts/Utils/EqualityComparer.cs` | Custom equality |
| `DisposableAction` | `Scripts/Utils/DisposableAction.cs` | Action с IDisposable |
| `DisposableComposite` | `Scripts/Utils/DisposableComposite.cs` | Composite disposable |
| `DisposableComposite<T>` | `Scripts/Utils/DisposableComposite`1.cs` | Typed composite disposable |
