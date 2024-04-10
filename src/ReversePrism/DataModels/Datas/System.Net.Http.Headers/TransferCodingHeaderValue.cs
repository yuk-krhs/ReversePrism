using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671BA0 ModelPrimitiveType string string string String
    // 018 Parameters                               000185CF5998 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    public partial class TransferCodingHeaderValue : DataModel
    {
        public string                                   Value                                   { get; set; }
        public List<NameValueHeaderValue>?              Parameters                              { get; set; }

        public static TransferCodingHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferCodingHeaderValue() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 02466B8FF920 0x10 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Parameters                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 02466B8FF940 0x18 Parameters                  ( 000185CF5998 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )

            return value;
        }
    }
}
