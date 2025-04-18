using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class IsPlayerTouchingCT : ConditionTask {
		public BBParameter<Transform> playerTransform;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			if(Mathf.Abs(playerTransform.value.position.x - agent.transform.position.x) < 0.75 && playerTransform.value.position.y > -999)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}