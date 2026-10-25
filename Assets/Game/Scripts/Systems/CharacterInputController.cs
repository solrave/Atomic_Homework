using System;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterInputController : MonoBehaviour
    {
        [SerializeField] 
        private Camera _camera;
        
        [SerializeField]
        private SceneEntity _character;

        private Plane _floor;

        private void Awake()
        {
            _floor = new Plane(Vector3.up, Vector3.zero);
        }

        private void Update()
        {
            HandleInput();
            UpdateLookDirection();
        }

        private void UpdateLookDirection()
        {
            var cameraRay = _camera.ScreenPointToRay(Input.mousePosition);
            if (_floor.Raycast(cameraRay, out var distance))
            {
                var point = cameraRay.GetPoint(distance);
                var lookDirection = point - _character.GetRigidbody().position;
                lookDirection.y = 0;
                _character.SetLookDirection(lookDirection.normalized);
            }
        }

        private void HandleInput()
        {
            var moveDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
                moveDirection.z = 1;
            
            if (Input.GetKey(KeyCode.S))
                moveDirection.z = -1;
            
            if (Input.GetKey(KeyCode.A))
                moveDirection.x = -1;
            
            if (Input.GetKey(KeyCode.D))
                moveDirection.x = 1;
            
            if (Input.GetKeyDown(KeyCode.H))
                _character.GetTakeDamageRequest().Invoke(1);
            
            _character.GetMoveRequest().Invoke(moveDirection.normalized);
        }
    }
}