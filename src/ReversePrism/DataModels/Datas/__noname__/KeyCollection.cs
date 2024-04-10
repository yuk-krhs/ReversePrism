using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expando                                  0001865277A0 ModelClassType ExpandoObject ExpandoObject ExpandoObject Pointer
    // 018 ExpandoVersion                           0001865F4260 ModelPrimitiveType int int int Int32
    // 01C ExpandoCount                             0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ExpandoData                              000186665B70 ModelClassType ExpandoData ExpandoData ExpandoData Pointer
    public partial class KeyCollection : DataModel
    {
        public ExpandoObject?                           Expando                                 { get; set; }
        public int                                      ExpandoVersion                          { get; set; }
        public int                                      ExpandoCount                            { get; set; }
        public ExpandoData?                             ExpandoData                             { get; set; }

        public static KeyCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyCollection() { Pointer= p0 };

            value.Expando                                   = GetObject<ExpandoObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExpandoObject.FromPointer); // 02466A0D6030 0x10 Expando                     ( 0001865277A0 ModelClassType ExpandoObject ExpandoObject ExpandoObject Pointer )
            value.ExpandoVersion                            = GetInt32(new IntPtr(p + 0x018)); // 02466A0D6050 0x18 ExpandoVersion              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExpandoCount                              = GetInt32(new IntPtr(p + 0x01C)); // 02466A0D6070 0x1C ExpandoCount                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExpandoData                               = GetObject<ExpandoData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpandoData.FromPointer); // 02466A0D6090 0x20 ExpandoData                 ( 000186665B70 ModelClassType ExpandoData ExpandoData ExpandoData Pointer )

            return value;
        }
    }
}
