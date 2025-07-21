using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BranchingOrder                           ModelPrimitiveType int int int Int32
    // 014 LevelCount                               ModelPrimitiveType int int int Int32
    // 018 AllocationCount                          ModelPrimitiveType int int int Int32
    // 01C FreeAllocationIdsCount                   ModelPrimitiveType int int int Int32
    public partial class Header : DataModel
    {
        public int                                      BranchingOrder                          { get; set; }
        public int                                      LevelCount                              { get; set; }
        public int                                      AllocationCount                         { get; set; }
        public int                                      FreeAllocationIdsCount                  { get; set; }

        public static Header? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Header() { Pointer= p0 };

            value.BranchingOrder                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 BranchingOrder              ( ModelPrimitiveType int int int Int32 )
            value.LevelCount                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 LevelCount                  ( ModelPrimitiveType int int int Int32 )
            value.AllocationCount                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 AllocationCount             ( ModelPrimitiveType int int int Int32 )
            value.FreeAllocationIdsCount                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C FreeAllocationIdsCount      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
