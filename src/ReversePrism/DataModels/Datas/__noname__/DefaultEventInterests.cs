using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultActionCategories                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 DefaultActionAtTargetCategories          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DefaultEventInterests : DataModel
    {
        public int                                      DefaultActionCategories                 { get; set; }
        public int                                      DefaultActionAtTargetCategories         { get; set; }

        public static DefaultEventInterests? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultEventInterests() { Pointer= p0 };

            value.DefaultActionCategories                   = GetInt32(new IntPtr(p + 0x010)); // 0245A681C358 0x10 DefaultActionCategories     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DefaultActionAtTargetCategories           = GetInt32(new IntPtr(p + 0x014)); // 0245A681C378 0x14 DefaultActionAtTargetCategories ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
