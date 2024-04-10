using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnLockedHashSetIds                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 isUnLockedHashSet                        HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class MedalGashaSaveData : DataModel
    {
        public List<int>?                               IsUnLockedHashSetIds                    { get; set; }

        public static MedalGashaSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaSaveData() { Pointer= p0 };

            value.IsUnLockedHashSetIds                      = GetInt32List(new IntPtr(p + 0x010)); // 0245A3A78DE8 0x10 IsUnLockedHashSetIds        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
