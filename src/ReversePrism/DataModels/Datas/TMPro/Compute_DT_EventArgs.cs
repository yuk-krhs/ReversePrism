using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventType                                ModelEnumType Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Int32
    // 014 ProgressPercentage                       ModelPrimitiveType float float float Single
    // 018 Colors                                   ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class Compute_DT_EventArgs : DataModel
    {
        public Compute_DistanceTransform_EventTypes     EventType                               { get; set; }
        public float                                    ProgressPercentage                      { get; set; }
        public List<Color>?                             Colors                                  { get; set; }

        public static Compute_DT_EventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Compute_DT_EventArgs() { Pointer= p0 };

            value.EventType                                 = (Compute_DistanceTransform_EventTypes)GetInt32(new IntPtr(p + 0x010)); // 0x10 EventType                   ( ModelEnumType Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Compute_DistanceTransform_EventTypes Int32 )
            value.ProgressPercentage                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 ProgressPercentage          ( ModelPrimitiveType float float float Single )
            value.Colors                                    = GetEnumList<Color>(new IntPtr(p + 0x018)); // 0x18 Colors                      ( ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
