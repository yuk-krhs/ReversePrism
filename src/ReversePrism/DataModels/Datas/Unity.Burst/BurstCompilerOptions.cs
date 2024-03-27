using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DisableCompilationArg                    string IL2CPP_TYPE_STRING
    // 000 ForceSynchronousCompilationArg           string IL2CPP_TYPE_STRING
    // 000 DefaultLibraryName                       string IL2CPP_TYPE_STRING
    // 000 BurstInitializeName                      string IL2CPP_TYPE_STRING
    // 000 BurstInitializeExternalsName             string IL2CPP_TYPE_STRING
    // 000 BurstInitializeStaticsName               string IL2CPP_TYPE_STRING
    // 000 OptionBurstcSwitch                       string IL2CPP_TYPE_STRING
    // 000 OptionGroup                              string IL2CPP_TYPE_STRING
    // 000 OptionPlatform                           string IL2CPP_TYPE_STRING
    // 000 OptionBackend                            string IL2CPP_TYPE_STRING
    // 000 OptionGlobalSafetyChecksSetting          string IL2CPP_TYPE_STRING
    // 000 OptionDisableSafetyChecks                string IL2CPP_TYPE_STRING
    // 000 OptionDisableOpt                         string IL2CPP_TYPE_STRING
    // 000 OptionFastMath                           string IL2CPP_TYPE_STRING
    // 000 OptionTarget                             string IL2CPP_TYPE_STRING
    // 000 OptionOptLevel                           string IL2CPP_TYPE_STRING
    // 000 OptionLogTimings                         string IL2CPP_TYPE_STRING
    // 000 OptionOptForSize                         string IL2CPP_TYPE_STRING
    // 000 OptionFloatPrecision                     string IL2CPP_TYPE_STRING
    // 000 OptionFloatMode                          string IL2CPP_TYPE_STRING
    // 000 OptionBranchProtection                   string IL2CPP_TYPE_STRING
    // 000 OptionDisableWarnings                    string IL2CPP_TYPE_STRING
    // 000 OptionAssemblyDefines                    string IL2CPP_TYPE_STRING
    // 000 OptionDump                               string IL2CPP_TYPE_STRING
    // 000 OptionFormat                             string IL2CPP_TYPE_STRING
    // 000 OptionDebugTrap                          string IL2CPP_TYPE_STRING
    // 000 OptionDisableVectors                     string IL2CPP_TYPE_STRING
    // 000 OptionDebug                              string IL2CPP_TYPE_STRING
    // 000 OptionDebugMode                          string IL2CPP_TYPE_STRING
    // 000 OptionStaticLinkage                      string IL2CPP_TYPE_STRING
    // 000 OptionJobMarshalling                     string IL2CPP_TYPE_STRING
    // 000 OptionTempDirectory                      string IL2CPP_TYPE_STRING
    // 000 OptionEnableDirectExternalLinking        string IL2CPP_TYPE_STRING
    // 000 OptionLinkerOptions                      string IL2CPP_TYPE_STRING
    // 000 OptionEnableAutoLayoutFallbackCheck      string IL2CPP_TYPE_STRING
    // 000 OptionGenerateLinkXml                    string IL2CPP_TYPE_STRING
    // 000 OptionMetaDataGeneration                 string IL2CPP_TYPE_STRING
    // 000 OptionDisableStringInterpolationInExceptionMessages string IL2CPP_TYPE_STRING
    // 000 OptionCacheDirectory                     string IL2CPP_TYPE_STRING
    // 000 OptionJitDisableFunctionCaching          string IL2CPP_TYPE_STRING
    // 000 OptionJitDisableAssemblyCaching          string IL2CPP_TYPE_STRING
    // 000 OptionJitEnableAssemblyCachingLogs       string IL2CPP_TYPE_STRING
    // 000 OptionJitEnableSynchronousCompilation    string IL2CPP_TYPE_STRING
    // 000 OptionJitCompilationPriority             string IL2CPP_TYPE_STRING
    // 000 OptionJitIsForFunctionPointer            string IL2CPP_TYPE_STRING
    // 000 OptionJitManagedFunctionPointer          string IL2CPP_TYPE_STRING
    // 000 OptionJitManagedDelegateHandle           string IL2CPP_TYPE_STRING
    // 000 OptionEnableInterpreter                  string IL2CPP_TYPE_STRING
    // 000 OptionAotAssemblyFolder                  string IL2CPP_TYPE_STRING
    // 000 OptionRootAssembly                       string IL2CPP_TYPE_STRING
    // 000 OptionIncludeRootAssemblyReferences      string IL2CPP_TYPE_STRING
    // 000 OptionAotMethod                          string IL2CPP_TYPE_STRING
    // 000 OptionAotType                            string IL2CPP_TYPE_STRING
    // 000 OptionAotAssembly                        string IL2CPP_TYPE_STRING
    // 000 OptionAotOutputPath                      string IL2CPP_TYPE_STRING
    // 000 OptionAotKeepIntermediateFiles           string IL2CPP_TYPE_STRING
    // 000 OptionAotNoLink                          string IL2CPP_TYPE_STRING
    // 000 OptionAotPatchedAssembliesOutputFolder   string IL2CPP_TYPE_STRING
    // 000 OptionAotPinvokeNameToPatch              string IL2CPP_TYPE_STRING
    // 000 OptionAotExecuteMethodNameToFind         string IL2CPP_TYPE_STRING
    // 000 OptionAotOnlyStaticMethods               string IL2CPP_TYPE_STRING
    // 000 OptionMethodPrefix                       string IL2CPP_TYPE_STRING
    // 000 OptionAotNoNativeToolchain               string IL2CPP_TYPE_STRING
    // 000 OptionAotEmitLlvmObjects                 string IL2CPP_TYPE_STRING
    // 000 OptionAotKeyFolder                       string IL2CPP_TYPE_STRING
    // 000 OptionAotDecodeFolder                    string IL2CPP_TYPE_STRING
    // 000 OptionVerbose                            string IL2CPP_TYPE_STRING
    // 000 OptionValidateExternalToolChain          string IL2CPP_TYPE_STRING
    // 000 OptionCompilerThreads                    string IL2CPP_TYPE_STRING
    // 000 OptionChunkSize                          string IL2CPP_TYPE_STRING
    // 000 OptionPrintLogOnMissingPInvokeCallbackAttribute string IL2CPP_TYPE_STRING
    // 000 OptionOutputMode                         string IL2CPP_TYPE_STRING
    // 000 OptionAlwaysCreateOutput                 string IL2CPP_TYPE_STRING
    // 000 OptionAotPdbSearchPaths                  string IL2CPP_TYPE_STRING
    // 000 OptionSafetyChecks                       string IL2CPP_TYPE_STRING
    // 000 OptionLibraryOutputMode                  string IL2CPP_TYPE_STRING
    // 000 OptionCompilationId                      string IL2CPP_TYPE_STRING
    // 000 OptionTargetFramework                    string IL2CPP_TYPE_STRING
    // 000 OptionWorkaroundFramework                string IL2CPP_TYPE_STRING
    // 000 CompilerCommandShutdown                  string IL2CPP_TYPE_STRING
    // 000 CompilerCommandCancel                    string IL2CPP_TYPE_STRING
    // 000 CompilerCommandEnableCompiler            string IL2CPP_TYPE_STRING
    // 000 CompilerCommandDisableCompiler           string IL2CPP_TYPE_STRING
    // 000 CompilerCommandSetDefaultOptions         string IL2CPP_TYPE_STRING
    // 000 CompilerCommandTriggerSetupRecompilation string IL2CPP_TYPE_STRING
    // 000 CompilerCommandIsCurrentCompilationDone  string IL2CPP_TYPE_STRING
    // 000 CompilerCommandTriggerRecompilation      string IL2CPP_TYPE_STRING
    // 000 CompilerCommandInitialize                string IL2CPP_TYPE_STRING
    // 000 CompilerCommandDomainReload              string IL2CPP_TYPE_STRING
    // 000 CompilerCommandVersionNotification       string IL2CPP_TYPE_STRING
    // 000 CompilerCommandGetTargetCpuFromHost      string IL2CPP_TYPE_STRING
    // 000 CompilerCommandSetProfileCallbacks       string IL2CPP_TYPE_STRING
    // 000 CompilerCommandUnloadBurstNatives        string IL2CPP_TYPE_STRING
    // 000 CompilerCommandIsNativeApiAvailable      string IL2CPP_TYPE_STRING
    // 000 CompilerCommandILPPCompilation           string IL2CPP_TYPE_STRING
    // 000 CompilerCommandIsArmTestEnv              string IL2CPP_TYPE_STRING
    // 000 CompilerCommandNotifyAssemblyCompilationNotRequired string IL2CPP_TYPE_STRING
    // 000 CompilerCommandNotifyAssemblyCompilationFinished string IL2CPP_TYPE_STRING
    // 000 CompilerCommandNotifyCompilationStarted  string IL2CPP_TYPE_STRING
    // 000 CompilerCommandNotifyCompilationFinished string IL2CPP_TYPE_STRING
    // 000 CompilerCommandAotCompilation            string IL2CPP_TYPE_STRING
    // 000 CompilerCommandRequestInitialiseDebuggerCommmand string IL2CPP_TYPE_STRING
    // 000 CompilerCommandInitialiseDebuggerCommmand string IL2CPP_TYPE_STRING
    // 000 CompilerCommandRequestSetProtocolVersionEditor string IL2CPP_TYPE_STRING
    // 000 CompilerCommandSetProtocolVersionBurst   string IL2CPP_TYPE_STRING
    // 000 ForceDisableBurstCompilation             bool IL2CPP_TYPE_BOOLEAN
    // 001 ForceBurstCompilationSynchronously       bool IL2CPP_TYPE_BOOLEAN
    // 002 IsSecondaryUnityProcess                  bool IL2CPP_TYPE_BOOLEAN
    // 010 EnableBurstCompilation                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 EnableBurstCompileSynchronously          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 EnableBurstSafetyChecks                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 013 EnableBurstTimings                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 EnableBurstDebug                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 015 ForceEnableBurstSafetyChecks             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 016 IsGlobal                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 OptionsChanged                           0001866792B0 ModelClassType Action Action Action Pointer
    public partial class BurstCompilerOptions
    {
        public bool                                     EnableBurstCompilation                  { get; set; }
        public bool                                     EnableBurstCompileSynchronously         { get; set; }
        public bool                                     EnableBurstSafetyChecks                 { get; set; }
        public bool                                     EnableBurstTimings                      { get; set; }
        public bool                                     EnableBurstDebug                        { get; set; }
        public bool                                     ForceEnableBurstSafetyChecks            { get; set; }
        public bool                                     IsGlobal                                { get; set; }
        public Action?                                  OptionsChanged                          { get; set; }

        public static BurstCompilerOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BurstCompilerOptions();

            value.EnableBurstCompilation                    = GetBool(new IntPtr(p + 0x010)); // 02700349C168 0x10 EnableBurstCompilation      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnableBurstCompileSynchronously           = GetBool(new IntPtr(p + 0x011)); // 02700349C188 0x11 EnableBurstCompileSynchronously ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnableBurstSafetyChecks                   = GetBool(new IntPtr(p + 0x012)); // 02700349C1A8 0x12 EnableBurstSafetyChecks     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnableBurstTimings                        = GetBool(new IntPtr(p + 0x013)); // 02700349C1C8 0x13 EnableBurstTimings          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnableBurstDebug                          = GetBool(new IntPtr(p + 0x014)); // 02700349C1E8 0x14 EnableBurstDebug            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ForceEnableBurstSafetyChecks              = GetBool(new IntPtr(p + 0x015)); // 02700349C208 0x15 ForceEnableBurstSafetyChecks ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsGlobal                                  = GetBool(new IntPtr(p + 0x016)); // 02700349C228 0x16 IsGlobal                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.OptionsChanged                            = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 02700349C248 0x18 OptionsChanged              ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
