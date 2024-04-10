using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 <CharacterIconDescriptors>k__BackingField IList`1<CharacterIconDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class LiveMVIdolListCellData : DataModel
    {
        public int                                      UnitId                                  { get; set; }

        public static LiveMVIdolListCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVIdolListCellData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0246652196C8 0x10 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
