using Atomic.Entities;
using Game.UI;
using UnityEngine;

namespace Game
{
    public sealed class GameUIInstaller : SceneEntityInstaller<IGameUI>
    {
        [SerializeField]
        private HealthScreenView _healthScreenView;

        [SerializeField]
        private StatView _healthCount;
        
        [SerializeField]
        private StatView _ammoCount;
        
        [SerializeField]
        private StatView _killCount;
        
        public override void Install(IGameUI ui)
        {
            ui.AddHealthView(_healthScreenView);
            ui.AddHealthCount(_healthCount);
            ui.AddScoreView(_killCount);
            ui.AddAmmoCount(_ammoCount);
            ui.AddBehaviour<GameUIPresenter>();
        }
    }
}