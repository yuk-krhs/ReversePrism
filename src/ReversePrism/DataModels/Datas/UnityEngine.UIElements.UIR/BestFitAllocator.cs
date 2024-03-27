using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalSize                                000186699A20 ModelPrimitiveType uint uint uint UInt32
    // 018 M_FirstBlock                             0001866F8D10 ModelClassType Block Block Block Pointer
    // 020 M_FirstAvailableBlock                    0001866F8D10 ModelClassType Block Block Block Pointer
    // 028 M_BlockPool                              0001866F94B0 ModelClassType BlockPool BlockPool BlockPool Pointer
    // 030 M_HighWatermark                          000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class BestFitAllocator
    {
        public uint                                     TotalSize                               { get; set; }
        public Block?                                   M_FirstBlock                            { get; set; }
        public Block?                                   M_FirstAvailableBlock                   { get; set; }
        public BlockPool?                               M_BlockPool                             { get; set; }
        public uint                                     M_HighWatermark                         { get; set; }

        public static BestFitAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BestFitAllocator();

            value.TotalSize                                 = GetUInt32(new IntPtr(p + 0x010)); // 027006861F70 0x10 TotalSize                   ( 000186699A20 ModelPrimitiveType uint uint uint UInt32 )
            value.M_FirstBlock                              = GetObject<Block>(new IntPtr(p + 0x018), ReversePrism.DataModels.Block.FromPointer); // 027006861F90 0x18 M_FirstBlock                ( 0001866F8D10 ModelClassType Block Block Block Pointer )
            value.M_FirstAvailableBlock                     = GetObject<Block>(new IntPtr(p + 0x020), ReversePrism.DataModels.Block.FromPointer); // 027006861FB0 0x20 M_FirstAvailableBlock       ( 0001866F8D10 ModelClassType Block Block Block Pointer )
            value.M_BlockPool                               = GetObject<BlockPool>(new IntPtr(p + 0x028), ReversePrism.DataModels.BlockPool.FromPointer); // 027006861FD0 0x28 M_BlockPool                 ( 0001866F94B0 ModelClassType BlockPool BlockPool BlockPool Pointer )
            value.M_HighWatermark                           = GetUInt32(new IntPtr(p + 0x030)); // 027006861FF0 0x30 M_HighWatermark             ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
