using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cell                                     ModelClassType Cell Cell Cell Pointer
    // 018 BrickIndices                             ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer
    public partial class VoxelMeta : DataModel
    {
        public Cell?                                    Cell                                    { get; set; }
        public List<ushort>?                            BrickIndices                            { get; set; }

        public static VoxelMeta? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoxelMeta() { Pointer= p0 };

            value.Cell                                      = GetObject<Cell>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cell.FromPointer); // 0x10 Cell                        ( ModelClassType Cell Cell Cell Pointer )
            value.BrickIndices                              = GetUInt16List(new IntPtr(p + 0x018)); // 0x18 BrickIndices                ( ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer )

            return value;
        }
    }
}
