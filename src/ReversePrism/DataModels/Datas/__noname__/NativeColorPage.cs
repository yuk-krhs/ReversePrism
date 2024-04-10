using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsValid                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 PageAndID                                0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    public partial class NativeColorPage : DataModel
    {
        public int                                      IsValid                                 { get; set; }
        public Color32                                  PageAndID                               { get; set; }

        public static NativeColorPage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeColorPage() { Pointer= p0 };

            value.IsValid                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A67A0748 0x10 IsValid                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageAndID                                 = (Color32)GetInt32(new IntPtr(p + 0x014)); // 0245A67A0768 0x14 PageAndID                   ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
