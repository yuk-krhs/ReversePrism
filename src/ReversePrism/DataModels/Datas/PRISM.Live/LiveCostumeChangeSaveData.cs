using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsShowUnlockedCostumeOnly                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class LiveCostumeChangeSaveData : DataModel
    {
        public bool                                     IsShowUnlockedCostumeOnly               { get; set; }

        public static LiveCostumeChangeSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeSaveData() { Pointer= p0 };

            value.IsShowUnlockedCostumeOnly                 = GetBool(new IntPtr(p + 0x020)); // 0245A3A7CAD0 0x20 IsShowUnlockedCostumeOnly   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
