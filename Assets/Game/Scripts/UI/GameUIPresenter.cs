using Atomic.Elements;
using Game.UI;

namespace Game
{
    public class GameUIPresenter : IGameUIInit, IGameUIDispose
    {
        private HealthScreenView _healthView;
        private StatView _healthCountView;
        private StatView _ammoCountView;
        private StatView _killCountView;
        private IGameEntity _player;
        private readonly DisposableComposite _disposeBag = new();
        
        public void Init(IGameUI gameUI)
        {
            _healthView = gameUI.GetHealthView();
            _healthCountView = gameUI.GetHealthCount();
            _ammoCountView = gameUI.GetAmmoCount();
            _killCountView = gameUI.GetKillCount();
            _player = GameContext.Instance.GetPlayer();
            _healthCountView.SetVisible(true);
            _ammoCountView.SetVisible(true);
            _killCountView.SetVisible(true);
            
            _healthCountView.SetText(_player.GetCurrentHealth().Value.ToString());
            _ammoCountView.SetText(_player.GetWeapon().Value.GetAmmo().ToString());
            
            _player.GetCurrentHealth().Subscribe(this.DisplayHealth).AddTo(_disposeBag);
            _player.GetWeapon().Value.GetAmmo().Subscribe(this.DisplayAmmo).AddTo(_disposeBag);
            
            _player.GetTakeDamageEvent().Subscribe(this.DisplayDamage).AddTo(_disposeBag);
        }

        private void DisplayAmmo(float ammo)
        {
            _ammoCountView.SetText(ammo.ToString());
        }

        private void DisplayHealth(float health)
        {
            _healthCountView.SetText(health.ToString());
        }

        public void Dispose(IGameUI entity)
        {
            _disposeBag.Dispose();
        }
        
        private void DisplayDamage(float damage)
        {
            _healthView.TakeDamage(damage);
            var maxHealth = _player.GetMaxHealth().Value;
            var currentHealth = _player.GetCurrentHealth().Value;
            var percent = currentHealth / maxHealth;
            _healthView.ChangePercent(percent);
        }
    }
}