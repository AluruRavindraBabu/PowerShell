﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;



/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class HistoryStrings {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal HistoryStrings() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HistoryStrings", typeof(HistoryStrings).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot add history because the input object has a format that is not valid..
    /// </summary>
    internal static string AddHistoryInvalidInput {
        get {
            return ResourceManager.GetString("AddHistoryInvalidInput", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Note: {0} entries were cleared from the session history..
    /// </summary>
    internal static string ClearHistoryResult {
        get {
            return ResourceManager.GetString("ClearHistoryResult", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This command will clear all the entries from the session history..
    /// </summary>
    internal static string ClearHistoryWarning {
        get {
            return ResourceManager.GetString("ClearHistoryWarning", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The identifier {0} is not valid. Specify a positive number, and then try again..
    /// </summary>
    internal static string InvalidCountValue {
        get {
            return ResourceManager.GetString("InvalidCountValue", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The identifier {0} is not a valid value for a History identifier. Specify a positive number, and then try again..
    /// </summary>
    internal static string InvalidIdGetHistory {
        get {
            return ResourceManager.GetString("InvalidIdGetHistory", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The Invoke-History cmdlet is called repeatedly, in a loop..
    /// </summary>
    internal static string InvokeHistoryLoopDetected {
        get {
            return ResourceManager.GetString("InvokeHistoryLoopDetected", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot process multiple history commands. You can only run a single command by using Invoke-History..
    /// </summary>
    internal static string InvokeHistoryMultipleCommandsError {
        get {
            return ResourceManager.GetString("InvokeHistoryMultipleCommandsError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The count cannot be combined with multiple CommandLine parameters..
    /// </summary>
    internal static string NoCountWithMultipleCmdLine {
        get {
            return ResourceManager.GetString("NoCountWithMultipleCmdLine", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The count cannot be combined with multiple Ids..
    /// </summary>
    internal static string NoCountWithMultipleIds {
        get {
            return ResourceManager.GetString("NoCountWithMultipleIds", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot locate the history for command line {0}..
    /// </summary>
    internal static string NoHistoryForCommandline {
        get {
            return ResourceManager.GetString("NoHistoryForCommandline", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot locate the history for Id {0}..
    /// </summary>
    internal static string NoHistoryForId {
        get {
            return ResourceManager.GetString("NoHistoryForId", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot locate history..
    /// </summary>
    internal static string NoHistoryFound {
        get {
            return ResourceManager.GetString("NoHistoryFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot locate most recent history..
    /// </summary>
    internal static string NoLastHistoryEntryFound {
        get {
            return ResourceManager.GetString("NoLastHistoryEntryFound", resourceCulture);
        }
    }
}