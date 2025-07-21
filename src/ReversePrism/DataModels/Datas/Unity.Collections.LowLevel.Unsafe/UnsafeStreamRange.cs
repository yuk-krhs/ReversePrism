using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Block                                    IntPtr IL2CPP_TYPE_PTR
    // 018 OffsetInFirstBlock                       ModelPrimitiveType int int int Int32
    // 01C ElementCount                             ModelPrimitiveType int int int Int32
    // 020 LastOffset                               ModelPrimitiveType int int int Int32
    // 024 NumberOfBlocks                           ModelPrimitiveType int int int Int32
    public partial class UnsafeStreamRange : DataModel
    {
        public int                                      OffsetInFirstBlock                      { get; set; }
        public int                                      ElementCount                            { get; set; }
        public int                                      LastOffset                              { get; set; }
        public int                                      NumberOfBlocks                          { get; set; }

        public static UnsafeStreamRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeStreamRange() { Pointer= p0 };

            value.OffsetInFirstBlock                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 OffsetInFirstBlock          ( ModelPrimitiveType int int int Int32 )
            value.ElementCount                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ElementCount                ( ModelPrimitiveType int int int Int32 )
            value.LastOffset                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 LastOffset                  ( ModelPrimitiveType int int int Int32 )
            value.NumberOfBlocks                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 NumberOfBlocks              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
