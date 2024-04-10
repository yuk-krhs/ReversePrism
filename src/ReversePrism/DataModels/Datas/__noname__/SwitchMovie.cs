using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoviePath                                0001866722E0 ModelPrimitiveType string string string String
    // 018 CueSheetName                             0001866722E0 ModelPrimitiveType string string string String
    // 020 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    // 028 StartSec                                 0001865C2E50 ModelPrimitiveType double double double Double
    public partial class SwitchMovie : DataModel
    {
        public string                                   MoviePath                               { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public double                                   StartSec                                { get; set; }

        public static SwitchMovie? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchMovie() { Pointer= p0 };

            value.MoviePath                                 = GetString(new IntPtr(p + 0x010)); // 024664DF7E78 0x10 MoviePath                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 024664DF7E98 0x18 CueSheetName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 024664DF7EB8 0x20 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartSec                                  = GetDouble(new IntPtr(p + 0x028)); // 024664DF7ED8 0x28 StartSec                    ( 0001865C2E50 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
