using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartScript                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 LabelName                                0001866722E0 ModelPrimitiveType string string string String
    public partial class SceneData : DataModel
    {
        public int                                      StartScript                             { get; set; }
        public string                                   LabelName                               { get; set; }

        public static SceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneData() { Pointer= p0 };

            value.StartScript                               = GetInt32(new IntPtr(p + 0x010)); // 0245A5F951F8 0x10 StartScript                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LabelName                                 = GetString(new IntPtr(p + 0x018)); // 0245A5F95218 0x18 LabelName                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
