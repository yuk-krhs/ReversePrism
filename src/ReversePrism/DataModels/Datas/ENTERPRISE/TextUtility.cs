using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MultipleString                           string IL2CPP_TYPE_STRING
    // 008 unitList                                 string[] IL2CPP_TYPE_SZARRAY
    // 010 JapaneseUnits                            000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class TextUtility : DataModel
    {
        public List<string>?                            JapaneseUnits                           { get; set; }

        public static TextUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextUtility() { Pointer= p0 };

            value.JapaneseUnits                             = GetStringList(new IntPtr(p + 0x010)); // 0245A5F54958 0x10 JapaneseUnits               ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
