using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Throw                                    ThrowInstruction IL2CPP_TYPE_CLASS
    // 008 VoidThrow                                ThrowInstruction IL2CPP_TYPE_CLASS
    // 010 Rethrow                                  00018665F790 ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer
    // 018 VoidRethrow                              00018665F790 ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer
    // 010 HasResult                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 011 Rethrow                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ThrowInstruction : DataModel
    {
        public bool                                     Rethrow                                 { get; set; }
        public ThrowInstruction?                        VoidRethrow                             { get; set; }
        public bool                                     HasResult                               { get; set; }

        public static ThrowInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThrowInstruction() { Pointer= p0 };

            value.Rethrow                                   = GetBool(new IntPtr(p + 0x011)); // 02466A012550 0x11 Rethrow                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.VoidRethrow                               = GetObject<ThrowInstruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.ThrowInstruction.FromPointer); // 02466A012510 0x18 VoidRethrow                 ( 00018665F790 ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer )
            value.HasResult                                 = GetBool(new IntPtr(p + 0x010)); // 02466A012530 0x10 HasResult                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
