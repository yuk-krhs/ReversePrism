using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StringValue                              ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 SingleStringValue                        ModelPrimitiveType string string string String
    // 020 Items                                    ModelClassListType Item[] Item[] List<Item> Pointer
    // 028 FirstItem                                ModelPrimitiveType int int int Int32
    // 02C LastItem                                 ModelPrimitiveType int int int Int32
    public partial class AttributeValueCache : DataModel
    {
        public StringBuilder?                           StringValue                             { get; set; }
        public string                                   SingleStringValue                       { get; set; }
        public List<Item>?                              Items                                   { get; set; }
        public int                                      FirstItem                               { get; set; }
        public int                                      LastItem                                { get; set; }

        public static AttributeValueCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeValueCache() { Pointer= p0 };

            value.StringValue                               = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 StringValue                 ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.SingleStringValue                         = GetString(new IntPtr(p + 0x018)); // 0x18 SingleStringValue           ( ModelPrimitiveType string string string String )
            value.Items                                     = GetObjectList<Item>(new IntPtr(p + 0x020), ReversePrism.DataModels.Item.FromPointer); // 0x20 Items                       ( ModelClassListType Item[] Item[] List<Item> Pointer )
            value.FirstItem                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 FirstItem                   ( ModelPrimitiveType int int int Int32 )
            value.LastItem                                  = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LastItem                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
