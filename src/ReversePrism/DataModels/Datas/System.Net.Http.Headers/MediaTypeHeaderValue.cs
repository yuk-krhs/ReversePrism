using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameters                               ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    // 018 Media_type                               ModelPrimitiveType string string string String
    public partial class MediaTypeHeaderValue : DataModel
    {
        public List<NameValueHeaderValue>?              Parameters                              { get; set; }
        public string                                   Media_type                              { get; set; }

        public static MediaTypeHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MediaTypeHeaderValue() { Pointer= p0 };

            value.Parameters                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x010), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 0x10 Parameters                  ( ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )
            value.Media_type                                = GetString(new IntPtr(p + 0x018)); // 0x18 Media_type                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
