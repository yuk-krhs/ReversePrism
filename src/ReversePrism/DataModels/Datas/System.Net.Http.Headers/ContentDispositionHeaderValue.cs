using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DispositionType                          000186671910 ModelPrimitiveType string string string String
    // 018 Parameters                               000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    public partial class ContentDispositionHeaderValue : DataModel
    {
        public string                                   DispositionType                         { get; set; }
        public List<NameValueHeaderValue>?              Parameters                              { get; set; }

        public static ContentDispositionHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentDispositionHeaderValue() { Pointer= p0 };

            value.DispositionType                           = GetString(new IntPtr(p + 0x010)); // 02466B8DDF30 0x10 DispositionType             ( 000186671910 ModelPrimitiveType string string string String )
            value.Parameters                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 02466B8DDF50 0x18 Parameters                  ( 000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )

            return value;
        }
    }
}
