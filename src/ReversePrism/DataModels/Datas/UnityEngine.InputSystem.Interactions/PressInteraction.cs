using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PressPoint                               000186666050 ModelPrimitiveType float float float Single
    // 014 Behavior                                 000186510830 ModelEnumType PressBehavior PressBehavior PressBehavior Int32
    // 018 M_WaitingForRelease                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PressInteraction
    {
        public float                                    PressPoint                              { get; set; }
        public PressBehavior                            Behavior                                { get; set; }
        public bool                                     M_WaitingForRelease                     { get; set; }

        public static PressInteraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PressInteraction();

            value.PressPoint                                = GetSingle(new IntPtr(p + 0x010)); // 0270D787A870 0x10 PressPoint                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Behavior                                  = (PressBehavior)GetInt32(new IntPtr(p + 0x014)); // 0270D787A890 0x14 Behavior                    ( 000186510830 ModelEnumType PressBehavior PressBehavior PressBehavior Int32 )
            value.M_WaitingForRelease                       = GetBool(new IntPtr(p + 0x018)); // 0270D787A8B0 0x18 M_WaitingForRelease         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
