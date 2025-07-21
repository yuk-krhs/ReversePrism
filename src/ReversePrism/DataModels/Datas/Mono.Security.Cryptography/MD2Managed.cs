using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 State                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Checksum                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Count                                    ModelPrimitiveType int int int Int32
    // 048 X                                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 PI_SUBST                                 sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class MD2Managed : DataModel
    {
        public List<sbyte>?                             State                                   { get; set; }
        public List<sbyte>?                             Checksum                                { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public List<sbyte>?                             X                                       { get; set; }

        public static MD2Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MD2Managed() { Pointer= p0 };

            value.State                                     = GetSByteList(new IntPtr(p + 0x028)); // 0x28 State                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Checksum                                  = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Checksum                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x038)); // 0x38 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Count                       ( ModelPrimitiveType int int int Int32 )
            value.X                                         = GetSByteList(new IntPtr(p + 0x048)); // 0x48 X                           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
