# Atomic_Homework

Учебный прототип Top-Down шутера на Atomic Framework: персонаж с пистолетом бегает по уровню и убивает зомби.
Управление — два джойстика (движение; прицел + автоатака с задержкой первого выстрела 0.5 с). Есть счётчик убийств,
аптечки, патроны и триггер-зоны врагов.

- ТЗ: `HomeworkObjectives/Homework.docx` (тот же текст в `AtomicMD/Homework.pdf`) — источник цифр и механик.
- Unity 6000.2.15f1, сцена `Assets/Scenes/GameScene.unity`.

## Структура

- `Assets/Game/Scripts/` — весь код проекта (namespace `Game`). Сейчас там только `UI/HealthScreenView.cs`, `UI/StatView.cs`
  и заготовка `APIKeys/EntityAPI.atomic`; gameplay-код ещё не написан.
- `Assets/Game/Prefabs/Gameplay/` — Character, Enemy, Bullet, `Weapons/` (Pistol, Hand), `Items/` (AmmoItem, HealthItem).
- `Assets/Game/Animations`, `Audio`, `VFX` — ассеты (параметры Animator: IsMoving, Attack, TakeDamage, Death, событие `fire_event`).
- `Assets/Plugins/` — сторонние библиотеки (Atomic 2.0.0, DOTween, Odin, UniTask). **Не редактировать.**

## Архитектура (по ТЗ)

- Игровые объекты — сущности домена `GameEntity` (SceneEntity на префабах).
- Игровые системы — домен `GameContext` (SceneEntitySingleton на сцене).
- UI — MVP: View (`HealthScreenView`, `StatView`) + презентеры, которые подписываются на реактивное состояние.
- Домены генерируются через `Window/Atomic/Entities/Entity Domain Generator`, API значений/тегов — только через `.atomic`-файлы
  (`Tools/Atomic/Entities/Compile Entity API`). Сгенерированный код руками не править.
- Подробные правила и примеры — скилл `.claude/skills/atomic` (загружать при любой работе с gameplay-кодом).

## Критерии оценки

Процедурный подход, разделение данных и логики, переиспользуемые механики (общие для персонажа и зомби),
SOLID, MVP, читаемый код.
