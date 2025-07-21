using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   ModelPrimitiveType int int int Int32
    // 01C Size                                     ModelPrimitiveType int int int Int32
    // 020 TotalBytes                               ModelPrimitiveType int int int Int32
    // 024 Complete                                 ModelPrimitiveType bool bool bool Bool
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

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Size                        ( ModelPrimitiveType int int int Int32 )
            value.TotalBytes                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalBytes                  ( ModelPrimitiveType int int int Int32 )
            value.Complete                                  = GetBool(new IntPtr(p + 0x024)); // 0x24 Complete                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
