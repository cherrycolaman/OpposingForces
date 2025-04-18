﻿namespace NodeCanvas.Framework
{

    ///<summary> Core Execution Status enumeration</summary>
    public enum Status
    {
        ///<summary>The operation has failed.</summary>
        Failure = 0,
        ///<summary>The operation has succeeded.</summary>
        Success = 1,
        ///<summary>The operation is still running.</summary>
        Running = 2,
        ///<summary>Indicates a "ready" state. No operation is performed yet.</summary>
        Resting = 3,
        ///<summary>The operation encountered an error. Usually execution error. This status is unhandled and is neither considered Success nor Failure.</summary>
        Error = 4,
        ///<summary>The operation is considered optional and is neither Success nor Failure.</summary>
        Optional = 5,
    }

    ///<summary> Enumeration for boolean status result</summary>
	public enum BooleanStatus
    {
        Failure = 0,
        Success = 1
    }

    ///<summary>Usual final Statuses. Castable to Status</summary>
    public enum FinalStatus
    {
        Failure = 0,
        Success = 1,
        Optional = 5,
    }

    ///<summary>Used for policies</summary>
    public enum BehaviourPolicy
    {
        OnFailure = 0,
        OnSuccess = 1,
        OnSuccessOrFailure = 2,
    }
}