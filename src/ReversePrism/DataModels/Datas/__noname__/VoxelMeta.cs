using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cell                                     0001865B5C00 ModelClassType Cell Cell Cell Pointer
    // 018 BrickIndices                             000185D18EF8 ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer
    public partial class VoxelMeta
    {
        public Cell?                                    Cell                                    { get; set; }
        public List<ushort>?                            BrickIndices                            { get; set; }

        public static VoxelMeta? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoxelMeta();

            value.Cell                                      = GetObject<Cell>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cell.FromPointer); // 0270D91B70A0 0x10 Cell                        ( 0001865B5C00 ModelClassType Cell Cell Cell Pointer )
            value.BrickIndices                              = GetUInt16List(new IntPtr(p + 0x018)); // 0270D91B70C0 0x18 BrickIndices                ( 000185D18EF8 ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer )

            return value;
        }
    }
}
