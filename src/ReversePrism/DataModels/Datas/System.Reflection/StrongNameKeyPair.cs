using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PublicKey                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 KeyPairContainer                         ModelPrimitiveType string string string String
    // 020 KeyPairExported                          ModelPrimitiveType bool bool bool Bool
    // 028 KeyPairArray                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class StrongNameKeyPair : DataModel
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
            var value   = new StrongNameKeyPair() { Pointer= p0 };

            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x010)); // 0x10 PublicKey                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyPairContainer                          = GetString(new IntPtr(p + 0x018)); // 0x18 KeyPairContainer            ( ModelPrimitiveType string string string String )
            value.KeyPairExported                           = GetBool(new IntPtr(p + 0x020)); // 0x20 KeyPairExported             ( ModelPrimitiveType bool bool bool Bool )
            value.KeyPairArray                              = GetSByteList(new IntPtr(p + 0x028)); // 0x28 KeyPairArray                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
