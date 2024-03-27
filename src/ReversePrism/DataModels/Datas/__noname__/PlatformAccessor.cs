using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _exceptionHandler                        ExceptionHandler IL2CPP_TYPE_CLASS
    // 008 _impl                                    Impl IL2CPP_TYPE_CLASS
    // 010 App                                      000186594FB0 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer
    public partial class PlatformAccessor
    {
        public FirebaseApp?                             App                                     { get; set; }

        public static PlatformAccessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformAccessor();

            value.App                                       = GetObject<FirebaseApp>(new IntPtr(p + 0x010), ReversePrism.DataModels.FirebaseApp.FromPointer); // 0270DBC50020 0x10 App                         ( 000186594FB0 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer )

            return value;
        }
    }
}
