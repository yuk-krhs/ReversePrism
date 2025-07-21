using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectorName                             ModelPrimitiveType string string string String
    // 018 LabelCount                               ModelPrimitiveType int int int Int32
    // 020 LabelNames                               ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
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

            value.SelectorName                              = GetString(new IntPtr(p + 0x010)); // 0x10 SelectorName                ( ModelPrimitiveType string string string String )
            value.LabelCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 LabelCount                  ( ModelPrimitiveType int int int Int32 )
            value.LabelNames                                = GetStringList(new IntPtr(p + 0x020)); // 0x20 LabelNames                  ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
