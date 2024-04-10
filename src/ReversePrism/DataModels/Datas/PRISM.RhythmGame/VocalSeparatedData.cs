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
    public partial class VocalSeparatedData : DataModel
    {
        public int                                      CharacterIndex                          { get; set; }
        public string                                   CategoryKey                             { get; set; }
        public List<float>?                             ToggleVolumeTimes                       { get; set; }

        public static VocalSeparatedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VocalSeparatedData() { Pointer= p0 };

            value.CharacterIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0246650C1A18 0x10 CharacterIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CategoryKey                               = GetString(new IntPtr(p + 0x018)); // 0246650C1A38 0x18 CategoryKey                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ToggleVolumeTimes                         = GetSingleList(new IntPtr(p + 0x020)); // 0246650C1A58 0x20 ToggleVolumeTimes           ( 000185D0A1D8 ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer )

            return value;
        }
    }
}
