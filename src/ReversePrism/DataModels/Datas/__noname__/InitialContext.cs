using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Crashlytics                              000186540EF0 ModelClassType FBCrashlytics FBCrashlytics FBCrashlytics Pointer
    // 018 Analytics                                0001865409B0 ModelClassType FBAnalytics FBAnalytics FBAnalytics Pointer
    // 020 Installer                                0001865B3CF0 ModelClassType LoggerInstaller LoggerInstaller LoggerInstaller Pointer
    // 028 Firebase                                 0001865947E0 ModelClassType FirebaseAPI FirebaseAPI FirebaseAPI Pointer
    public partial class InitialContext
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
            var value   = new InitialContext();

            value.Crashlytics                               = GetObject<FBCrashlytics>(new IntPtr(p + 0x010), ReversePrism.DataModels.FBCrashlytics.FromPointer); // 027003C78958 0x10 Crashlytics                 ( 000186540EF0 ModelClassType FBCrashlytics FBCrashlytics FBCrashlytics Pointer )
            value.Analytics                                 = GetObject<FBAnalytics>(new IntPtr(p + 0x018), ReversePrism.DataModels.FBAnalytics.FromPointer); // 027003C78978 0x18 Analytics                   ( 0001865409B0 ModelClassType FBAnalytics FBAnalytics FBAnalytics Pointer )
            value.Installer                                 = GetObject<LoggerInstaller>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoggerInstaller.FromPointer); // 027003C78998 0x20 Installer                   ( 0001865B3CF0 ModelClassType LoggerInstaller LoggerInstaller LoggerInstaller Pointer )
            value.Firebase                                  = GetObject<FirebaseAPI>(new IntPtr(p + 0x028), ReversePrism.DataModels.FirebaseAPI.FromPointer); // 027003C789B8 0x28 Firebase                    ( 0001865947E0 ModelClassType FirebaseAPI FirebaseAPI FirebaseAPI Pointer )

            return value;
        }
    }
}
