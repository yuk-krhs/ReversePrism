using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsTouchMiniCharacterDisplay              ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleSelectionDetailModel : DataModel
    {
        public bool                                     IsTouchMiniCharacterDisplay             { get; set; }

        public static ScheduleSelectionDetailModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionDetailModel() { Pointer= p0 };

            value.IsTouchMiniCharacterDisplay               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsTouchMiniCharacterDisplay ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
