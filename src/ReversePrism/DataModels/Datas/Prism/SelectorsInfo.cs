using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectorName                             0001866722E0 ModelPrimitiveType string string string String
    // 018 LabelCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 LabelNames                               000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class SelectorsInfo : DataModel
    {
        public string                                   SelectorName                            { get; set; }
        public int                                      LabelCount                              { get; set; }
        public List<string>?                            LabelNames                              { get; set; }

        public static SelectorsInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorsInfo() { Pointer= p0 };

            value.SelectorName                              = GetString(new IntPtr(p + 0x010)); // 0245A424A8D8 0x10 SelectorName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LabelCount                                = GetInt32(new IntPtr(p + 0x018)); // 0245A424A8F8 0x18 LabelCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LabelNames                                = GetStringList(new IntPtr(p + 0x020)); // 0245A424A918 0x20 LabelNames                  ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
