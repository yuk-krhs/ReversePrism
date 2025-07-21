using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Exponent                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Modulus                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 P                                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Q                                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 DP                                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 DQ                                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 InverseQ                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 D                                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.Exponent                                  = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Exponent                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Modulus                                   = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Modulus                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.P                                         = GetSByteList(new IntPtr(p + 0x020)); // 0x20 P                           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Q                                         = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Q                           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DP                                        = GetSByteList(new IntPtr(p + 0x030)); // 0x30 DP                          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DQ                                        = GetSByteList(new IntPtr(p + 0x038)); // 0x38 DQ                          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InverseQ                                  = GetSByteList(new IntPtr(p + 0x040)); // 0x40 InverseQ                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.D                                         = GetSByteList(new IntPtr(p + 0x048)); // 0x48 D                           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
