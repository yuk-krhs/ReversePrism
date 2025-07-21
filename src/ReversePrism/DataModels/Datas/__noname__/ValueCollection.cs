using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expando                                  ModelClassType ExpandoObject ExpandoObject ExpandoObject Pointer
    // 018 ExpandoVersion                           ModelPrimitiveType int int int Int32
    // 01C ExpandoCount                             ModelPrimitiveType int int int Int32
    // 020 ExpandoData                              ModelClassType ExpandoData ExpandoData ExpandoData Pointer
    public partial class ValueCollection : DataModel
    {
        public ExpandoObject?                           Expando                                 { get; set; }
        public int                                      ExpandoVersion                          { get; set; }
        public int                                      ExpandoCount                            { get; set; }
        public ExpandoData?                             ExpandoData                             { get; set; }

        public static ValueCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueCollection() { Pointer= p0 };

            value.Expando                                   = GetObject<ExpandoObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExpandoObject.FromPointer); // 0x10 Expando                     ( ModelClassType ExpandoObject ExpandoObject ExpandoObject Pointer )
            value.ExpandoVersion                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 ExpandoVersion              ( ModelPrimitiveType int int int Int32 )
            value.ExpandoCount                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ExpandoCount                ( ModelPrimitiveType int int int Int32 )
            value.ExpandoData                               = GetObject<ExpandoData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExpandoData.FromPointer); // 0x20 ExpandoData                 ( ModelClassType ExpandoData ExpandoData ExpandoData Pointer )

            return value;
        }
    }
}
