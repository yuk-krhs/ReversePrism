using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 State                                    ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 030 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Count                                    ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 X                                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 Digest                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MD4Managed : DataModel
    {
        public List<uint>?                              State                                   { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public List<uint>?                              Count                                   { get; set; }
        public List<uint>?                              X                                       { get; set; }
        public List<sbyte>?                             Digest                                  { get; set; }

        public static MD4Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MD4Managed() { Pointer= p0 };

            value.State                                     = GetUInt32List(new IntPtr(p + 0x028)); // 0x28 State                       ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetUInt32List(new IntPtr(p + 0x038)); // 0x38 Count                       ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.X                                         = GetUInt32List(new IntPtr(p + 0x040)); // 0x40 X                           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Digest                                    = GetSByteList(new IntPtr(p + 0x048)); // 0x48 Digest                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
