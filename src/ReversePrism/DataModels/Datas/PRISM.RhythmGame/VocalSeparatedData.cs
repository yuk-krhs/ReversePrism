using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIndex                           ModelPrimitiveType int int int Int32
    // 018 CategoryKey                              ModelPrimitiveType string string string String
    // 020 ToggleVolumeTimes                        ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer
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

            value.CharacterIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterIndex              ( ModelPrimitiveType int int int Int32 )
            value.CategoryKey                               = GetString(new IntPtr(p + 0x018)); // 0x18 CategoryKey                 ( ModelPrimitiveType string string string String )
            value.ToggleVolumeTimes                         = GetSingleList(new IntPtr(p + 0x020)); // 0x20 ToggleVolumeTimes           ( ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer )

            return value;
        }
    }
}
