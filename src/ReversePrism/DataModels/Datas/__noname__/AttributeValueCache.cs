using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StringValue                              000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 SingleStringValue                        000186671910 ModelPrimitiveType string string string String
    // 020 Items                                    000185CCAE68 ModelClassListType Item[] Item[] List<Item> Pointer
    // 028 FirstItem                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C LastItem                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AttributeValueCache
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
            var value   = new AttributeValueCache();

            value.StringValue                               = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7408F58 0x10 StringValue                 ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.SingleStringValue                         = GetString(new IntPtr(p + 0x018)); // 0270D7408F78 0x18 SingleStringValue           ( 000186671910 ModelPrimitiveType string string string String )
            value.Items                                     = GetObjectList<Item>(new IntPtr(p + 0x020), ReversePrism.DataModels.Item.FromPointer); // 0270D7408F98 0x20 Items                       ( 000185CCAE68 ModelClassListType Item[] Item[] List<Item> Pointer )
            value.FirstItem                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D7408FB8 0x28 FirstItem                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastItem                                  = GetInt32(new IntPtr(p + 0x02C)); // 0270D7408FD8 0x2C LastItem                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
