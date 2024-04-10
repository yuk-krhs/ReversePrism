using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CurrentUser                              RegistryKey IL2CPP_TYPE_CLASS
    // 008 LocalMachine                             RegistryKey IL2CPP_TYPE_CLASS
    // 010 ClassesRoot                              000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer
    // 018 Users                                    000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer
    // 020 PerformanceData                          000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer
    // 028 CurrentConfig                            000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer
    // 030 DynData                                  000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer
    public partial class Registry : DataModel
    {
        public RegistryKey?                             ClassesRoot                             { get; set; }
        public RegistryKey?                             Users                                   { get; set; }
        public RegistryKey?                             PerformanceData                         { get; set; }
        public RegistryKey?                             CurrentConfig                           { get; set; }
        public RegistryKey?                             DynData                                 { get; set; }

        public static Registry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Registry() { Pointer= p0 };

            value.ClassesRoot                               = GetObject<RegistryKey>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegistryKey.FromPointer); // 024662FD7EB8 0x10 ClassesRoot                 ( 000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer )
            value.Users                                     = GetObject<RegistryKey>(new IntPtr(p + 0x018), ReversePrism.DataModels.RegistryKey.FromPointer); // 024662FD7ED8 0x18 Users                       ( 000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer )
            value.PerformanceData                           = GetObject<RegistryKey>(new IntPtr(p + 0x020), ReversePrism.DataModels.RegistryKey.FromPointer); // 024662FD7EF8 0x20 PerformanceData             ( 000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer )
            value.CurrentConfig                             = GetObject<RegistryKey>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegistryKey.FromPointer); // 024662FD7F18 0x28 CurrentConfig               ( 000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer )
            value.DynData                                   = GetObject<RegistryKey>(new IntPtr(p + 0x030), ReversePrism.DataModels.RegistryKey.FromPointer); // 024662FD7F38 0x30 DynData                     ( 000186645F00 ModelClassType RegistryKey RegistryKey RegistryKey Pointer )

            return value;
        }
    }
}
