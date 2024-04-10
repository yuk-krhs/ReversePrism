using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Size                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 TotalBytes                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Complete                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class BufferOffsetSize : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Size                                    { get; set; }
        public int                                      TotalBytes                              { get; set; }
        public bool                                     Complete                                { get; set; }

        public static BufferOffsetSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferOffsetSize() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 024667974388 0x10 Buffer                      ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0246679743A8 0x18 Offset                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246679743C8 0x1C Size                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalBytes                                = GetInt32(new IntPtr(p + 0x020)); // 0246679743E8 0x20 TotalBytes                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Complete                                  = GetBool(new IntPtr(p + 0x024)); // 024667974408 0x24 Complete                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
