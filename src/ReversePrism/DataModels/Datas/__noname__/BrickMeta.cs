using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 voxels                                   HashSet`1<Vector3Int> IL2CPP_TYPE_GENERICINST
    // 018 Bricks                                   000185D28698 ModelEnumListType List`1<ReservedBrick> List`1<ReservedBrick> List<ReservedBrick> Pointer
    public partial class BrickMeta : DataModel
    {
        public List<ReservedBrick>?                     Bricks                                  { get; set; }

        public static BrickMeta? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrickMeta() { Pointer= p0 };

            value.Bricks                                    = GetEnumList<ReservedBrick>(new IntPtr(p + 0x018)); // 02466920DFD8 0x18 Bricks                      ( 000185D28698 ModelEnumListType List`1<ReservedBrick> List`1<ReservedBrick> List<ReservedBrick> Pointer )

            return value;
        }
    }
}
