using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Nonce                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 TargetName                               000186671910 ModelPrimitiveType string string string String
    // 028 TargetInfo                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class Type2Message : DataModel
    {
        public List<sbyte>?                             Nonce                                   { get; set; }
        public string                                   TargetName                              { get; set; }
        public List<sbyte>?                             TargetInfo                              { get; set; }

        public static Type2Message? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Type2Message() { Pointer= p0 };

            value.Nonce                                     = GetSByteList(new IntPtr(p + 0x018)); // 02466B40CDC0 0x18 Nonce                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TargetName                                = GetString(new IntPtr(p + 0x020)); // 02466B40CDE0 0x20 TargetName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.TargetInfo                                = GetSByteList(new IntPtr(p + 0x028)); // 02466B40CE00 0x28 TargetInfo                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
