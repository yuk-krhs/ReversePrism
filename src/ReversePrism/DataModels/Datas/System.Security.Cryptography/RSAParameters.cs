using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Exponent                                 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Modulus                                  000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 P                                        000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Q                                        000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 DP                                       000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 DQ                                       000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 InverseQ                                 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 D                                        000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class RSAParameters : DataModel
    {
        public List<sbyte>?                             Exponent                                { get; set; }
        public List<sbyte>?                             Modulus                                 { get; set; }
        public List<sbyte>?                             P                                       { get; set; }
        public List<sbyte>?                             Q                                       { get; set; }
        public List<sbyte>?                             DP                                      { get; set; }
        public List<sbyte>?                             DQ                                      { get; set; }
        public List<sbyte>?                             InverseQ                                { get; set; }
        public List<sbyte>?                             D                                       { get; set; }

        public static RSAParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RSAParameters() { Pointer= p0 };

            value.Exponent                                  = GetSByteList(new IntPtr(p + 0x010)); // 0246669D1940 0x10 Exponent                    ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Modulus                                   = GetSByteList(new IntPtr(p + 0x018)); // 0246669D1960 0x18 Modulus                     ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.P                                         = GetSByteList(new IntPtr(p + 0x020)); // 0246669D1980 0x20 P                           ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Q                                         = GetSByteList(new IntPtr(p + 0x028)); // 0246669D19A0 0x28 Q                           ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DP                                        = GetSByteList(new IntPtr(p + 0x030)); // 0246669D19C0 0x30 DP                          ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DQ                                        = GetSByteList(new IntPtr(p + 0x038)); // 0246669D19E0 0x38 DQ                          ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InverseQ                                  = GetSByteList(new IntPtr(p + 0x040)); // 0246669D1A00 0x40 InverseQ                    ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.D                                         = GetSByteList(new IntPtr(p + 0x048)); // 0246669D1A20 0x48 D                           ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
