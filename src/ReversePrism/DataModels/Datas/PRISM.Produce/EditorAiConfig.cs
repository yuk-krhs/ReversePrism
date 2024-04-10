using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActivePatternSetIndex                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ActiveSynergyIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class EditorAiConfig : DataModel
    {
        public int                                      ActivePatternSetIndex                   { get; set; }
        public int                                      ActiveSynergyIndex                      { get; set; }

        public static EditorAiConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAiConfig() { Pointer= p0 };

            value.ActivePatternSetIndex                     = GetInt32(new IntPtr(p + 0x010)); // 024665B0E6C8 0x10 ActivePatternSetIndex       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActiveSynergyIndex                        = GetInt32(new IntPtr(p + 0x014)); // 024665B0E6E8 0x14 ActiveSynergyIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
