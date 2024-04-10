using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Constructor                              0001866100F0 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 018 ArgumentCount                            0001865F4700 ModelPrimitiveType int int int Int32
    public partial class NewInstruction : DataModel
    {
        public ConstructorInfo?                         Constructor                             { get; set; }
        public int                                      ArgumentCount                           { get; set; }

        public static NewInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewInstruction() { Pointer= p0 };

            value.Constructor                               = GetObject<ConstructorInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 02466A07DE68 0x10 Constructor                 ( 0001866100F0 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.ArgumentCount                             = GetInt32(new IntPtr(p + 0x018)); // 02466A07DE88 0x18 ArgumentCount               ( 0001865F4700 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
