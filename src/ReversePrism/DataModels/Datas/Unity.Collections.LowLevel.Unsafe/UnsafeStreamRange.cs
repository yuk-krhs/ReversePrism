using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Block                                    IntPtr IL2CPP_TYPE_PTR
    // 018 OffsetInFirstBlock                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C ElementCount                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 LastOffset                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 NumberOfBlocks                           0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.OffsetInFirstBlock                        = GetInt32(new IntPtr(p + 0x018)); // 024669EEE7A0 0x18 OffsetInFirstBlock          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ElementCount                              = GetInt32(new IntPtr(p + 0x01C)); // 024669EEE7C0 0x1C ElementCount                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LastOffset                                = GetInt32(new IntPtr(p + 0x020)); // 024669EEE7E0 0x20 LastOffset                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumberOfBlocks                            = GetInt32(new IntPtr(p + 0x024)); // 024669EEE800 0x24 NumberOfBlocks              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
