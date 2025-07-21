using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwigCPtr                                 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 020 SwigCMemOwn                              ModelPrimitiveType bool bool bool Bool
    // 000 disposeLock                              <object> IL2CPP_TYPE_OBJECT
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 AppDisposed                              ModelClassType EventHandler EventHandler EventHandler Pointer
    // 008 nameToProxy                              Dictionary`2<string, FirebaseApp> IL2CPP_TYPE_GENERICINST
    // 010 cPtrToProxy                              Dictionary`2<<int>, FirebaseApp> IL2CPP_TYPE_GENERICINST
    // 018 AppUtilCallbacksInitialized              ModelPrimitiveType bool bool bool Bool
    // 020 AppUtilCallbacksLock                     <object> IL2CPP_TYPE_OBJECT
    // 028 PreventOnAllAppsDestroyed                ModelPrimitiveType bool bool bool Bool
    // 029 CrashlyticsInitializationAttempted       ModelPrimitiveType bool bool bool Bool
    // 02A UserAgentRegistered                      ModelPrimitiveType bool bool bool Bool
    // 000 CheckDependenciesNoThread                int IL2CPP_TYPE_I4
    // 000 CheckDependenciesPendingThread           int IL2CPP_TYPE_I4
    // 02C CheckDependenciesThread                  ModelPrimitiveType int int int Int32
    // 030 CheckDependenciesThreadLock              <object> IL2CPP_TYPE_OBJECT
    // 038 AppPlatform                              ModelClassType FirebaseAppPlatform FirebaseAppPlatform FirebaseAppPlatform Pointer
    public partial class FirebaseApp : DataModel
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public bool                                     SwigCMemOwn                             { get; set; }
        public string                                   Name                                    { get; set; }
        public EventHandler?                            AppDisposed                             { get; set; }
        public bool                                     AppUtilCallbacksInitialized             { get; set; }
        public bool                                     PreventOnAllAppsDestroyed               { get; set; }
        public bool                                     CrashlyticsInitializationAttempted      { get; set; }
        public bool                                     UserAgentRegistered                     { get; set; }
        public int                                      CheckDependenciesThread                 { get; set; }
        public FirebaseAppPlatform?                     AppPlatform                             { get; set; }

        public static FirebaseApp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseApp() { Pointer= p0 };

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0x10 SwigCPtr                    ( ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0x20 SwigCMemOwn                 ( ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.AppDisposed                               = GetObject<EventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventHandler.FromPointer); // 0x30 AppDisposed                 ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.AppUtilCallbacksInitialized               = GetBool(new IntPtr(p + 0x018)); // 0x18 AppUtilCallbacksInitialized ( ModelPrimitiveType bool bool bool Bool )
            value.PreventOnAllAppsDestroyed                 = GetBool(new IntPtr(p + 0x028)); // 0x28 PreventOnAllAppsDestroyed   ( ModelPrimitiveType bool bool bool Bool )
            value.CrashlyticsInitializationAttempted        = GetBool(new IntPtr(p + 0x029)); // 0x29 CrashlyticsInitializationAttempted ( ModelPrimitiveType bool bool bool Bool )
            value.UserAgentRegistered                       = GetBool(new IntPtr(p + 0x02A)); // 0x2A UserAgentRegistered         ( ModelPrimitiveType bool bool bool Bool )
            value.CheckDependenciesThread                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C CheckDependenciesThread     ( ModelPrimitiveType int int int Int32 )
            value.AppPlatform                               = GetObject<FirebaseAppPlatform>(new IntPtr(p + 0x038), ReversePrism.DataModels.FirebaseAppPlatform.FromPointer); // 0x38 AppPlatform                 ( ModelClassType FirebaseAppPlatform FirebaseAppPlatform FirebaseAppPlatform Pointer )

            return value;
        }
    }
}
