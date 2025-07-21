using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 HashAlgorithm                            ModelPrimitiveType string string string String
    // 020 AuthenticatedAttributes                  ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 UnauthenticatedAttributes                ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 Signature                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Issuer                                   ModelPrimitiveType string string string String
    // 040 Serial                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Ski                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.Version                                   = GetSByte(new IntPtr(p + 0x010)); // 0x10 Version                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.HashAlgorithm                             = GetString(new IntPtr(p + 0x018)); // 0x18 HashAlgorithm               ( ModelPrimitiveType string string string String )
            value.AuthenticatedAttributes                   = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 AuthenticatedAttributes     ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.UnauthenticatedAttributes                 = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 UnauthenticatedAttributes   ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Signature                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Issuer                                    = GetString(new IntPtr(p + 0x038)); // 0x38 Issuer                      ( ModelPrimitiveType string string string String )
            value.Serial                                    = GetSByteList(new IntPtr(p + 0x040)); // 0x40 Serial                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ski                                       = GetSByteList(new IntPtr(p + 0x048)); // 0x48 Ski                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
