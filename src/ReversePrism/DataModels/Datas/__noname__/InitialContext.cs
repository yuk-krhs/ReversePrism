using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Crashlytics                              ModelClassType FBCrashlytics FBCrashlytics FBCrashlytics Pointer
    // 018 Analytics                                ModelClassType FBAnalytics FBAnalytics FBAnalytics Pointer
    // 020 Installer                                ModelClassType LoggerInstaller LoggerInstaller LoggerInstaller Pointer
    // 028 Firebase                                 ModelClassType FirebaseAPI FirebaseAPI FirebaseAPI Pointer
    public partial class InitialContext : DataModel
    {
        public FBCrashlytics?                           Crashlytics                             { get; set; }
        public FBAnalytics?                             Analytics                               { get; set; }
        public LoggerInstaller?                         Installer                               { get; set; }
        public FirebaseAPI?                             Firebase                                { get; set; }

        public static InitialContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitialContext() { Pointer= p0 };

            value.Crashlytics                               = GetObject<FBCrashlytics>(new IntPtr(p + 0x010), ReversePrism.DataModels.FBCrashlytics.FromPointer); // 0x10 Crashlytics                 ( ModelClassType FBCrashlytics FBCrashlytics FBCrashlytics Pointer )
            value.Analytics                                 = GetObject<FBAnalytics>(new IntPtr(p + 0x018), ReversePrism.DataModels.FBAnalytics.FromPointer); // 0x18 Analytics                   ( ModelClassType FBAnalytics FBAnalytics FBAnalytics Pointer )
            value.Installer                                 = GetObject<LoggerInstaller>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoggerInstaller.FromPointer); // 0x20 Installer                   ( ModelClassType LoggerInstaller LoggerInstaller LoggerInstaller Pointer )
            value.Firebase                                  = GetObject<FirebaseAPI>(new IntPtr(p + 0x028), ReversePrism.DataModels.FirebaseAPI.FromPointer); // 0x28 Firebase                    ( ModelClassType FirebaseAPI FirebaseAPI FirebaseAPI Pointer )

            return value;
        }
    }
}
