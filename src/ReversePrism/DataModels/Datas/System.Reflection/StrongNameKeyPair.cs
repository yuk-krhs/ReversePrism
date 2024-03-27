using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PublicKey                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 KeyPairContainer                         000186671910 ModelPrimitiveType string string string String
    // 020 KeyPairExported                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 KeyPairArray                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class StrongNameKeyPair
    {
        public List<sbyte>?                             PublicKey                               { get; set; }
        public string                                   KeyPairContainer                        { get; set; }
        public bool                                     KeyPairExported                         { get; set; }
        public List<sbyte>?                             KeyPairArray                            { get; set; }

        public static StrongNameKeyPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StrongNameKeyPair();

            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x010)); // 0270D6CED8B0 0x10 PublicKey                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyPairContainer                          = GetString(new IntPtr(p + 0x018)); // 0270D6CED8D0 0x18 KeyPairContainer            ( 000186671910 ModelPrimitiveType string string string String )
            value.KeyPairExported                           = GetBool(new IntPtr(p + 0x020)); // 0270D6CED8F0 0x20 KeyPairExported             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.KeyPairArray                              = GetSByteList(new IntPtr(p + 0x028)); // 0270D6CED910 0x28 KeyPairArray                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
