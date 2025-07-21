using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 VelocityThreshold                        ModelPrimitiveType float float float Single
    // 018 Duration                                 ModelPrimitiveType float float float Single
    // 01C Easing                                   ModelEnumType Ease Ease Ease Int32
    public partial class Snap : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public float                                    VelocityThreshold                       { get; set; }
        public float                                    Duration                                { get; set; }
        public Ease                                     Easing                                  { get; set; }

        public static Snap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Snap() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.VelocityThreshold                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 VelocityThreshold           ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 Duration                    ( ModelPrimitiveType float float float Single )
            value.Easing                                    = (Ease)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Easing                      ( ModelEnumType Ease Ease Ease Int32 )

            return value;
        }
    }
}
