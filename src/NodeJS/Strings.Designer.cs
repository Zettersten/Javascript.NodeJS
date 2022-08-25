﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jering.Javascript.NodeJS {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jering.Javascript.NodeJS.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If moduleSourceType is cache, moduleSource cannot be null..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleSourceCannotBeNull {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleSourceCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If moduleSourceType is file or string, moduleSource cannot be null, whitespace or an empty string..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleSourceCannotBeNullWhitespaceOrAnEmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleSourceCannotBeNullWhitespaceOrAnEmptySt" +
                        "ring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If moduleSourceType is stream, moduleStreamSource cannot be null..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleStreamSourceCannotBeNull {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleStreamSourceCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a StreamReader..
        /// </summary>
        internal static string ArgumentException_NodeJSProcess_ExpectedAStreamReader {
            get {
                return ResourceManager.GetString("ArgumentException_NodeJSProcess_ExpectedAStreamReader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process has exited..
        /// </summary>
        internal static string ArgumentException_NodeJSProcess_ProcessHasExited {
            get {
                return ResourceManager.GetString("ArgumentException_NodeJSProcess_ProcessHasExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process has not been started or has been disposed of..
        /// </summary>
        internal static string ArgumentException_NodeJSProcess_ProcessHasNotBeenStartedOrHasBeenDisposed {
            get {
                return ResourceManager.GetString("ArgumentException_NodeJSProcess_ProcessHasNotBeenStartedOrHasBeenDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty..
        /// </summary>
        internal static string ArgumentException_Shared_ValueCannotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentException_Shared_ValueCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null, whitespace or an empty string..
        /// </summary>
        internal static string ArgumentException_Shared_ValueCannotBeNullWhitespaceOrAnEmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_Shared_ValueCannotBeNullWhitespaceOrAnEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NodeJS connection attempt timed out after {0}ms. ProcessID: {1}. Process exited: {2}. Exit status: {3}..
        /// </summary>
        internal static string ConnectionException_OutOfProcessNodeJSService_ConnectionAttemptTimedOut {
            get {
                return ResourceManager.GetString("ConnectionException_OutOfProcessNodeJSService_ConnectionAttemptTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to NodeJS. Refer to the inner exception for details..
        /// </summary>
        internal static string ConnectionException_OutOfProcessNodeJSService_FailedToConnect {
            get {
                return ResourceManager.GetString("ConnectionException_OutOfProcessNodeJSService_FailedToConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process with ID {0} exited before connecting..
        /// </summary>
        internal static string ConnectionException_OutOfProcessNodeJSService_ProcessExitedBeforeConnecting {
            get {
                return ResourceManager.GetString("ConnectionException_OutOfProcessNodeJSService_ProcessExitedBeforeConnecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation count below minimum. This might be because ExitBlock is being called more than once for some EnterBlockAsync invocations. It could also be because DrainBlockAndPreventEntryAsync is being called multiple times without calls to ResetAfterDraining in between..
        /// </summary>
        internal static string InvalidOperationException_BlockDrain_OperationCountBelowMinimum {
            get {
                return ResourceManager.GetString("InvalidOperationException_BlockDrain_OperationCountBelowMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream is null..
        /// </summary>
        internal static string InvalidOperationException_InvocationRequest_StreamIsNull {
            get {
                return ResourceManager.GetString("InvalidOperationException_InvocationRequest_StreamIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream is unseekable..
        /// </summary>
        internal static string InvalidOperationException_InvocationRequest_StreamIsUnseekable {
            get {
                return ResourceManager.GetString("InvalidOperationException_InvocationRequest_StreamIsUnseekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start Node process. To resolve this:
        ///
        ///[1] Ensure that NodeJS is installed and can be found in one of the PATH directories. The current PATH enviroment variable is: {0}. Make sure that the Node executable is in one of those directories, or update your PATH.
        ///
        ///[2] Refer to the InnerException for further details..
        /// </summary>
        internal static string InvalidOperationException_NodeJSProcessFactory_FailedToStartNodeProcess {
            get {
                return ResourceManager.GetString("InvalidOperationException_NodeJSProcessFactory_FailedToStartNodeProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No embedded resource with specified name: {0}..
        /// </summary>
        internal static string InvalidOperations_EmbeddedResourcesService_NoEmbeddedResourceWithSpecifiedName {
            get {
                return ResourceManager.GetString("InvalidOperations_EmbeddedResourcesService_NoEmbeddedResourceWithSpecifiedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a HTTP response with an unexpected status code: {0}..
        /// </summary>
        internal static string InvocationException_HttpNodeJSService_UnexpectedStatusCode {
            get {
                return ResourceManager.GetString("InvocationException_HttpNodeJSService_UnexpectedStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invocation timed out after {0}ms. You can change the timeout duration by setting {1}.{2}. Do ensure that your NodeJS function invokes its callback (or throws an exception if it is an async function)..
        /// </summary>
        internal static string InvocationException_OutOfProcessNodeJSService_InvocationTimedOut {
            get {
                return ResourceManager.GetString("InvocationException_OutOfProcessNodeJSService_InvocationTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Releasing process connection semaphore, processID: {0}, thread ID: {1}, thread is ThreadPool thread : {2}..
        /// </summary>
        internal static string LogDebug_OutOfProcessNodeJSService_ReleasingProcessConnectionSemaphore {
            get {
                return ResourceManager.GetString("LogDebug_OutOfProcessNodeJSService_ReleasingProcessConnectionSemaphore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting on process connection semaphore, processID: {0}, thread ID: {1}, thread is ThreadPool thread : {2}..
        /// </summary>
        internal static string LogDebug_OutOfProcessNodeJSService_WaitingOnProcessConnectionSemaphore {
            get {
                return ResourceManager.GetString("LogDebug_OutOfProcessNodeJSService_WaitingOnProcessConnectionSemaphore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to NodeJS process: {0}..
        /// </summary>
        internal static string LogInformation_ConnectedToNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_ConnectedToNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File changed: &quot;{0}&quot;. Moving to new NodeJS process..
        /// </summary>
        internal static string LogInformation_FileChangedMovingtoNewNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_FileChangedMovingtoNewNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to NodeJS through {0}. Endpoint: {1}..
        /// </summary>
        internal static string LogInformation_HttpEndpoint {
            get {
                return ResourceManager.GetString("LogInformation_HttpEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Killing NodeJS process: {0}..
        /// </summary>
        internal static string LogInformation_KillingNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_KillingNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process exited before connecting..
        /// </summary>
        internal static string LogInformation_ProcessExitedBeforeConnecting {
            get {
                return ResourceManager.GetString("LogInformation_ProcessExitedBeforeConnecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attempt to connect to NodeJS failed. Retries remaining: {0}.
        ///Exception:
        ///  {1}.
        /// </summary>
        internal static string LogWarning_ConnectionAttemptFailed {
            get {
                return ResourceManager.GetString("LogWarning_ConnectionAttemptFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invocation attempt failed. Retries using existing process remaining: {0}.
        ///Exception:
        ///  {1}.
        /// </summary>
        internal static string LogWarning_InvocationAttemptFailed {
            get {
                return ResourceManager.GetString("LogWarning_InvocationAttemptFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retries in existing process exhausted. Process retries remaining: {0}..
        /// </summary>
        internal static string LogWarning_RetriesInExistingProcessExhausted {
            get {
                return ResourceManager.GetString("LogWarning_RetriesInExistingProcessExhausted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use MoveToNewProcessAsync instead since it allows for asynchronous waiting..
        /// </summary>
        internal static string Obsolete_MoveToNewProcess {
            get {
                return ResourceManager.GetString("Obsolete_MoveToNewProcess", resourceCulture);
            }
        }
    }
}
