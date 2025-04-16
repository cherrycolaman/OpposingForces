using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class IsBullTouching : ConditionTask {
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
			if (Mathf.Abs(playerTransform.value.position.x - agent.transform.position.x) < 1.5
				&& Mathf.Abs(playerTransform.value.position.y - agent.transform.position.y) < 1.5
				&& Mathf.Abs(playerTransform.value.position.z - agent.transform.position.z) < 1.5)
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