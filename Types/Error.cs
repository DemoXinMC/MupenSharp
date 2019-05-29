using System;
using System.Collections.Generic;
using System.Text;

namespace MupenSharp.Types
{
    public enum Error
    {
        Success = 0,
        /// <summary>
        /// Function is disallowed before InitMupen64Plus() is called
        /// </summary>
        NotInitialized,

        /// <summary>
        /// InitMupen64Plus() was called twice
        /// </summary>
        AlreadyInitialized,

        /// <summary>
        /// API versions between components are incompatible
        /// </summary>
        Incompatible,

        /// <summary>
        /// Invalid parameters for function call, such as ParamValue=NULL for GetCoreParameter()
        /// </summary>
        InputAssert,

        /// <summary>
        /// Invalid input data, such as ParamValue="maybe" for SetCoreParameter() to set a BOOL-type value
        /// </summary>
        InputInvalid,

        /// <summary>
        /// The input parameter(s) specified a particular item which was not found
        /// </summary>
        InputNotFound,

        /// <summary>
        /// Memory allocation failed
        /// </summary>
        NoMemory,

        /// <summary>
        /// Error opening, creating, reading, or writing to a file
        /// </summary>
        Files,

        /// <summary>
        /// Internal error (bug)
        /// </summary>
        Internal,

        /// <summary>
        /// Current program state does not allow operation
        /// </summary>
        InvalidState,

        /// <summary>
        /// A plugin function returned a fatal error
        /// </summary>
        PluginFailure,

        /// <summary>
        /// A system function call, such as an SDL or file operation, failed
        /// </summary>
        SystemFailure,

        /// <summary>
        /// Function call is not supported (ie, core not built with debugger)
        /// </summary>
        Unsupported,
        WrongType
    }
}
