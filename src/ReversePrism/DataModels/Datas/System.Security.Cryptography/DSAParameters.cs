using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 P                                        000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Q                                        000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 G                                        000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Y                                        000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 J                                        000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 X                                        000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Seed                                     000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Counter                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DSAParameters : DataModel
    {
        public List<sbyte>?                             P                                       { get; set; }
        public List<sbyte>?                             Q                                       { get; set; }
        public List<sbyte>?                             G                                       { get; set; }
        public List<sbyte>?                             Y                                       { get; set; }
        public List<sbyte>?                             J                                       { get; set; }
        public List<sbyte>?                             X                                       { get; set; }
        public List<sbyte>?                             Seed                                    { get; set; }
        public int                                      Counter                                 { get; set; }

        public static DSAParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSAParameters() { Pointer= p0 };

            value.P                                         = GetSByteList(new IntPtr(p + 0x010)); // 0246669D2500 0x10 P                           ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Q                                         = GetSByteList(new IntPtr(p + 0x018)); // 0246669D2520 0x18 Q                           ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.G                                         = GetSByteList(new IntPtr(p + 0x020)); // 0246669D2540 0x20 G                           ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Y                                         = GetSByteList(new IntPtr(p + 0x028)); // 0246669D2560 0x28 Y                           ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.J                                         = GetSByteList(new IntPtr(p + 0x030)); // 0246669D2580 0x30 J                           ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.X                                         = GetSByteList(new IntPtr(p + 0x038)); // 0246669D25A0 0x38 X                           ( 000185B7A7F0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Seed                                      = GetSByteList(new IntPtr(p + 0x040)); // 0246669D25C0 0x40 Seed                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Counter                                   = GetInt32(new IntPtr(p + 0x048)); // 0246669D25E0 0x48 Counter                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
