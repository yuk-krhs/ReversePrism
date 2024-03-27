using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwigCPtr                                 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 020 SwigCMemOwn                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 disposeLock                              <object> IL2CPP_TYPE_OBJECT
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 AppDisposed                              000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 008 nameToProxy                              Dictionary`2<string, FirebaseApp> IL2CPP_TYPE_GENERICINST
    // 010 cPtrToProxy                              Dictionary`2<<int>, FirebaseApp> IL2CPP_TYPE_GENERICINST
    // 018 AppUtilCallbacksInitialized              000186595C30 ModelPrimitiveType bool bool bool Bool
    // 020 AppUtilCallbacksLock                     <object> IL2CPP_TYPE_OBJECT
    // 028 PreventOnAllAppsDestroyed                000186595C30 ModelPrimitiveType bool bool bool Bool
    // 029 CrashlyticsInitializationAttempted       000186595C30 ModelPrimitiveType bool bool bool Bool
    // 02A UserAgentRegistered                      000186595C30 ModelPrimitiveType bool bool bool Bool
    // 000 CheckDependenciesNoThread                int IL2CPP_TYPE_I4
    // 000 CheckDependenciesPendingThread           int IL2CPP_TYPE_I4
    // 02C CheckDependenciesThread                  0001865F38E0 ModelPrimitiveType int int int Int32
    // 030 CheckDependenciesThreadLock              <object> IL2CPP_TYPE_OBJECT
    // 038 AppPlatform                              000186595740 ModelClassType FirebaseAppPlatform FirebaseAppPlatform FirebaseAppPlatform Pointer
    public partial class FirebaseApp
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
            var value   = new FirebaseApp();

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0270DB76F180 0x10 SwigCPtr                    ( 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0270DB76F1A0 0x20 SwigCMemOwn                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270DB76F1E0 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.AppDisposed                               = GetObject<EventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventHandler.FromPointer); // 0270DB76F200 0x30 AppDisposed                 ( 000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.AppUtilCallbacksInitialized               = GetBool(new IntPtr(p + 0x018)); // 0270DB76F260 0x18 AppUtilCallbacksInitialized ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.PreventOnAllAppsDestroyed                 = GetBool(new IntPtr(p + 0x028)); // 0270DB76F2A0 0x28 PreventOnAllAppsDestroyed   ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.CrashlyticsInitializationAttempted        = GetBool(new IntPtr(p + 0x029)); // 0270DB76F2C0 0x29 CrashlyticsInitializationAttempted ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.UserAgentRegistered                       = GetBool(new IntPtr(p + 0x02A)); // 0270DB76F2E0 0x2A UserAgentRegistered         ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.CheckDependenciesThread                   = GetInt32(new IntPtr(p + 0x02C)); // 0270DB76F340 0x2C CheckDependenciesThread     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.AppPlatform                               = GetObject<FirebaseAppPlatform>(new IntPtr(p + 0x038), ReversePrism.DataModels.FirebaseAppPlatform.FromPointer); // 0270DB76F380 0x38 AppPlatform                 ( 000186595740 ModelClassType FirebaseAppPlatform FirebaseAppPlatform FirebaseAppPlatform Pointer )

            return value;
        }
    }
}
