using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 M_AisacControls                          0001866722E0 ModelPrimitiveType string string string String
    // 0A8 M_StopOnWrapping                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A9 M_StopAtGraphEnd                         000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomTrack : DataModel
    {
        public string                                   M_AisacControls                         { get; set; }
        public bool                                     M_StopOnWrapping                        { get; set; }
        public bool                                     M_StopAtGraphEnd                        { get; set; }

        public static CriAtomTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomTrack() { Pointer= p0 };

            value.M_AisacControls                           = GetString(new IntPtr(p + 0x0A0)); // 02466AD618A8 0xA0 M_AisacControls             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.M_StopOnWrapping                          = GetBool(new IntPtr(p + 0x0A8)); // 02466AD618C8 0xA8 M_StopOnWrapping            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_StopAtGraphEnd                          = GetBool(new IntPtr(p + 0x0A9)); // 02466AD618E8 0xA9 M_StopAtGraphEnd            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
