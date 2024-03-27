using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIndex                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CategoryKey                              0001866722E0 ModelPrimitiveType string string string String
    // 020 ToggleVolumeTimes                        000185D0A1D8 ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer
    public partial class VocalSeparatedData
    {
        public int                                      CharacterIndex                          { get; set; }
        public string                                   CategoryKey                             { get; set; }
        public List<float>?                             ToggleVolumeTimes                       { get; set; }

        public static VocalSeparatedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VocalSeparatedData();

            value.CharacterIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0270D5056AE0 0x10 CharacterIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CategoryKey                               = GetString(new IntPtr(p + 0x018)); // 0270D5056B00 0x18 CategoryKey                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ToggleVolumeTimes                         = GetSingleList(new IntPtr(p + 0x020)); // 0270D5056B20 0x20 ToggleVolumeTimes           ( 000185D0A1D8 ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer )

            return value;
        }
    }
}
