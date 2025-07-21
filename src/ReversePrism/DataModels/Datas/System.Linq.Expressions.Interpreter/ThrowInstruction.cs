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
    // 010 Rethrow                                  ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer
    // 018 VoidRethrow                              ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer
    // 010 HasResult                                ModelPrimitiveType bool bool bool Bool
    // 011 Rethrow                                  ModelPrimitiveType bool bool bool Bool
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

            value.Rethrow                                   = GetBool(new IntPtr(p + 0x011)); // 0x11 Rethrow                     ( ModelPrimitiveType bool bool bool Bool )
            value.VoidRethrow                               = GetObject<ThrowInstruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.ThrowInstruction.FromPointer); // 0x18 VoidRethrow                 ( ModelClassType ThrowInstruction ThrowInstruction ThrowInstruction Pointer )
            value.HasResult                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 HasResult                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
