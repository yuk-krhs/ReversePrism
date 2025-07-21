using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Full_name                                ModelPrimitiveType string string string String
    // 018 Default_ctor                             ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer
    public partial class MonoTypeInfo : DataModel
    {
        public string                                   Full_name                               { get; set; }
        public RuntimeConstructorInfo?                  Default_ctor                            { get; set; }

        public static MonoTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTypeInfo() { Pointer= p0 };

            value.Full_name                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Full_name                   ( ModelPrimitiveType string string string String )
            value.Default_ctor                              = GetObject<RuntimeConstructorInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeConstructorInfo.FromPointer); // 0x18 Default_ctor                ( ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer )

            return value;
        }
    }
}
