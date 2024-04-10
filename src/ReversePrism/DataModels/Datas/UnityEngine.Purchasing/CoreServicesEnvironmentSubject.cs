using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               CoreServicesEnvironmentSubject IL2CPP_TYPE_CLASS
    // 000 k_DefaultLiveEnvironment                 string IL2CPP_TYPE_STRING
    // 010 M_LastKnownEnvironment                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Observers                              000185CE1C18 ModelClassListType List`1<ICoreServicesEnvironmentObserver> List`1<ICoreServicesEnvironmentObserver> List<ICoreServicesEnvironmentObserver> Pointer
    public partial class CoreServicesEnvironmentSubject : DataModel
    {
        public string                                   M_LastKnownEnvironment                  { get; set; }
        public List<ICoreServicesEnvironmentObserver>?  M_Observers                             { get; set; }

        public static CoreServicesEnvironmentSubject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreServicesEnvironmentSubject() { Pointer= p0 };

            value.M_LastKnownEnvironment                    = GetString(new IntPtr(p + 0x010)); // 0245A4C10D38 0x10 M_LastKnownEnvironment      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Observers                               = GetObjectList<ICoreServicesEnvironmentObserver>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICoreServicesEnvironmentObserver.FromPointer); // 0245A4C10D58 0x18 M_Observers                 ( 000185CE1C18 ModelClassListType List`1<ICoreServicesEnvironmentObserver> List`1<ICoreServicesEnvironmentObserver> List<ICoreServicesEnvironmentObserver> Pointer )

            return value;
        }
    }
}
