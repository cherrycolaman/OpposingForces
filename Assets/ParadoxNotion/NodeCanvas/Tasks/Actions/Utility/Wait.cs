﻿using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions
{

    [Category("✫ Utility")]
    public class Wait : ActionTask
    {

        public BBParameter<float> waitTime = 1f;
        public BooleanStatus finishStatus = BooleanStatus.Success;

        protected override string info {
            get { return string.Format("Wait {0} sec.", waitTime); }
        }

        protected override void OnUpdate() {
            if ( elapsedTime >= waitTime.value ) {
                EndAction(finishStatus == BooleanStatus.Success ? true : false);
            }
        }
    }
}