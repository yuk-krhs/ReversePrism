using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_hasValue                               NullableMethodCallInstruction IL2CPP_TYPE_CLASS
    // 008 s_value                                  NullableMethodCallInstruction IL2CPP_TYPE_CLASS
    // 010 S_equals                                 0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer
    // 018 S_getHashCode                            0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer
    // 020 S_getValueOrDefault1                     0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer
    // 028 S_toString                               0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer
    public partial class NullableMethodCallInstruction : DataModel
    {
        public NullableMethodCallInstruction?           S_equals                                { get; set; }
        public NullableMethodCallInstruction?           S_getHashCode                           { get; set; }
        public NullableMethodCallInstruction?           S_getValueOrDefault1                    { get; set; }
        public NullableMethodCallInstruction?           S_toString                              { get; set; }

        public static NullableMethodCallInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullableMethodCallInstruction() { Pointer= p0 };

            value.S_equals                                  = GetObject<NullableMethodCallInstruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.NullableMethodCallInstruction.FromPointer); // 02466A0A5058 0x10 S_equals                    ( 0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer )
            value.S_getHashCode                             = GetObject<NullableMethodCallInstruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.NullableMethodCallInstruction.FromPointer); // 02466A0A5078 0x18 S_getHashCode               ( 0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer )
            value.S_getValueOrDefault1                      = GetObject<NullableMethodCallInstruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.NullableMethodCallInstruction.FromPointer); // 02466A0A5098 0x20 S_getValueOrDefault1        ( 0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer )
            value.S_toString                                = GetObject<NullableMethodCallInstruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.NullableMethodCallInstruction.FromPointer); // 02466A0A50B8 0x28 S_toString                  ( 0001866BFB00 ModelClassType NullableMethodCallInstruction NullableMethodCallInstruction NullableMethodCallInstruction Pointer )

            return value;
        }
    }
}
