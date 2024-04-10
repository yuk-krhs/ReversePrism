using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 NumTracks                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CueInfoEx : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      NumTracks                               { get; set; }

        public static CueInfoEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueInfoEx() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024664F27500 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NumTracks                                 = GetInt32(new IntPtr(p + 0x018)); // 024664F27520 0x18 NumTracks                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
