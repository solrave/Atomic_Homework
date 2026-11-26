using Atomic.Elements;
using Game.UI;

namespace Game
{
    public class GameUIPresenter : IGameUIInit, IGameUIDispose
    {
        private HealthScreenView _healthView;
        private StatView _healthCountView;
        private StatView _ammoCountView;
        private StatView _scoreView;
        private IGameEntity _player;
        private IReactiveVariable<int> _score;
        private readonly DisposableComposite _disposeBag = new();
        
        public void Init(IGameUI gameUI)
        {
            _player = GameContext.Instance.GetPlayer();
            _healthView = gameUI.GetHealthView();
            _scoreView = gameUI.GetScoreView();
            _ammoCountView = gameUI.GetAmmoCount();
            _healthCountView = gameUI.GetHealthCount();
            _score = GameContext.Instance.GetScore();
            _score.Subscribe(this.SetScore).AddTo(_disposeBag);
            
            _player.GetCurrentHealth().Subscribe(this.DisplayHealth).AddTo(_disposeBag);
            _player.GetWeapon().Value.GetAmmo().Subscribe(this.DisplayAmmo).AddTo(_disposeBag);
            _player.GetTakeDamageEvent().Subscribe(this.DisplayDamage).AddTo(_disposeBag);
            
            _healthCountView.SetVisible(true);
            _healthCountView.SetText(_player.GetCurrentHealth().Value.ToString());
            
            _scoreView.SetVisible(true);
            _scoreView.SetText(_score.Value.ToString());
            
            _ammoCountView.SetVisible(true);
            _ammoCountView.SetText(_player.GetWeapon().Value.GetAmmo().ToString());
        }
        
        public void Dispose(IGameUI entity)
        {
            _disposeBag.Dispose();
        }

        private void SetScore(int score)
        {
            _scoreView.SetText(score.ToString());
        }

        private void DisplayAmmo(float ammo)
        {
            _ammoCountView.SetText(ammo.ToString());
        }

        private void DisplayHealth(float health)
        {
            _healthCountView.SetText(health.ToString());
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