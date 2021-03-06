// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
//
/*=============================================================================
**
**
**
** Purpose: The exception class for misc execution engine exceptions.
**          Currently, its only used as a placeholder type when the EE
**          does a FailFast.
**
**
=============================================================================*/

using System;
using System.Runtime.Serialization;

namespace System
{
    [Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
    public sealed class ExecutionEngineException : SystemException
    {
        public ExecutionEngineException()
            : base(SR.Arg_ExecutionEngineException)
        {
            HResult = __HResults.COR_E_EXECUTIONENGINE;
        }

        public ExecutionEngineException(String message)
            : base(message)
        {
            HResult = __HResults.COR_E_EXECUTIONENGINE;
        }

        public ExecutionEngineException(String message, Exception innerException)
            : base(message, innerException)
        {
            HResult = __HResults.COR_E_EXECUTIONENGINE;
        }
    }
}
