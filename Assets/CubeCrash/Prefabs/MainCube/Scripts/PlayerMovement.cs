using UnityEngine;

namespace Xioniks {

	class PlayerMovement : MonoBehaviour
	{
		[SerializeField] float _speed;
		[SerializeField] Transform _target;


		Vector3 _targetPos;
		Vector3 _pos;
		

		private void Start() {
			
		}

		private void Update() {

			Vector3 _targetPos = _target.position;
			Vector3 _pos = transform.position;

			transform.position = Vector3.MoveTowards(_pos, _targetPos, _speed);

			if(Input.GetKeyDown(KeyCode.A)) {
				transform.position = new Vector3(transform.position.x - 0.7f, transform.position.y, transform.position.z);
				transform.Rotate(0f, 0f, 90f);
			}

			if(Input.GetKeyDown(KeyCode.D)) {
				transform.position = new Vector3(transform.position.x + 0.7f,transform.position.y, transform.position.z);
				transform.Rotate(0f, 0f, -90f);
			}
		}
	}
}