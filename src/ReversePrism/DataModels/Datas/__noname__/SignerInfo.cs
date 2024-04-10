using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 HashAlgorithm                            000186671910 ModelPrimitiveType string string string String
    // 020 AuthenticatedAttributes                  00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 UnauthenticatedAttributes                00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 Signature                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Issuer                                   000186671910 ModelPrimitiveType string string string String
    // 040 Serial                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Ski                                      000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class SignerInfo : DataModel
    {
        public sbyte                                    Version                                 { get; set; }
        public string                                   HashAlgorithm                           { get; set; }
        public ArrayList?                               AuthenticatedAttributes                 { get; set; }
        public ArrayList?                               UnauthenticatedAttributes               { get; set; }
        public List<sbyte>?                             Signature                               { get; set; }
        public string                                   Issuer                                  { get; set; }
        public List<sbyte>?                             Serial                                  { get; set; }
        public List<sbyte>?                             Ski                                     { get; set; }

        public static SignerInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignerInfo() { Pointer= p0 };

            value.Version                                   = GetSByte(new IntPtr(p + 0x010)); // 02466B4075D8 0x10 Version                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.HashAlgorithm                             = GetString(new IntPtr(p + 0x018)); // 02466B4075F8 0x18 HashAlgorithm               ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthenticatedAttributes                   = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 02466B407618 0x20 AuthenticatedAttributes     ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.UnauthenticatedAttributes                 = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 02466B407638 0x28 UnauthenticatedAttributes   ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x030)); // 02466B407658 0x30 Signature                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Issuer                                    = GetString(new IntPtr(p + 0x038)); // 02466B407678 0x38 Issuer                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Serial                                    = GetSByteList(new IntPtr(p + 0x040)); // 02466B407698 0x40 Serial                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ski                                       = GetSByteList(new IntPtr(p + 0x048)); // 02466B4076B8 0x48 Ski                         ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
