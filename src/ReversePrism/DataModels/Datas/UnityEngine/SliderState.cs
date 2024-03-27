using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DragStartPos                             000186666050 ModelPrimitiveType float float float Single
    // 014 DragStartValue                           000186666050 ModelPrimitiveType float float float Single
    // 018 IsDragging                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class SliderState
    {
        public float                                    DragStartPos                            { get; set; }
        public float                                    DragStartValue                          { get; set; }
        public bool                                     IsDragging                              { get; set; }

        public static SliderState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliderState();

            value.DragStartPos                              = GetSingle(new IntPtr(p + 0x010)); // 0270021E6B00 0x10 DragStartPos                ( 000186666050 ModelPrimitiveType float float float Single )
            value.DragStartValue                            = GetSingle(new IntPtr(p + 0x014)); // 0270021E6B20 0x14 DragStartValue              ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsDragging                                = GetBool(new IntPtr(p + 0x018)); // 0270021E6B40 0x18 IsDragging                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
