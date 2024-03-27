using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Full_name                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Default_ctor                             000186697A60 ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer
    public partial class MonoTypeInfo
    {
        public string                                   Full_name                               { get; set; }
        public RuntimeConstructorInfo?                  Default_ctor                            { get; set; }

        public static MonoTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTypeInfo();

            value.Full_name                                 = GetString(new IntPtr(p + 0x010)); // 027002E601E0 0x10 Full_name                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Default_ctor                              = GetObject<RuntimeConstructorInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeConstructorInfo.FromPointer); // 027002E60200 0x18 Default_ctor                ( 000186697A60 ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer )

            return value;
        }
    }
}
