using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventType                                0001865F7F30 ModelEnumType Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Int32
    // 014 ProgressPercentage                       000186666050 ModelPrimitiveType float float float Single
    // 018 Colors                                   000185B75AA0 ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class Compute_DT_EventArgs
    {
        public Compute_DistanceTransform_EventTypes     EventType                               { get; set; }
        public float                                    ProgressPercentage                      { get; set; }
        public List<Color>?                             Colors                                  { get; set; }

        public static Compute_DT_EventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Compute_DT_EventArgs();

            value.EventType                                 = (Compute_DistanceTransform_EventTypes)GetInt32(new IntPtr(p + 0x010)); // 0270D0FD7718 0x10 EventType                   ( 0001865F7F30 ModelEnumType Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Int32 )
            value.ProgressPercentage                        = GetSingle(new IntPtr(p + 0x014)); // 0270D0FD7738 0x14 ProgressPercentage          ( 000186666050 ModelPrimitiveType float float float Single )
            value.Colors                                    = GetEnumList<Color>(new IntPtr(p + 0x018)); // 0270D0FD7758 0x18 Colors                      ( 000185B75AA0 ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
