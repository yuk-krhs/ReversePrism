using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parameters                               000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    public partial class NameValueWithParametersHeaderValue
    {
        public List<NameValueHeaderValue>?              Parameters                              { get; set; }

        public static NameValueWithParametersHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameValueWithParametersHeaderValue();

            value.Parameters                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 0270DB8807B8 0x20 Parameters                  ( 000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )

            return value;
        }
    }
}
