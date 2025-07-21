using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoviePath                                ModelPrimitiveType string string string String
    // 018 CueSheetName                             ModelPrimitiveType string string string String
    // 020 CueName                                  ModelPrimitiveType string string string String
    // 028 StartSec                                 ModelPrimitiveType double double double Double
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

            value.MoviePath                                 = GetString(new IntPtr(p + 0x010)); // 0x10 MoviePath                   ( ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 0x18 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 0x20 CueName                     ( ModelPrimitiveType string string string String )
            value.StartSec                                  = GetDouble(new IntPtr(p + 0x028)); // 0x28 StartSec                    ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
