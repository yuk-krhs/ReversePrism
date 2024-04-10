using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Parameters                               000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer
    public partial class NameValueWithParametersHeaderValue : DataModel
    {
        public List<NameValueHeaderValue>?              Parameters                              { get; set; }

        public static NameValueWithParametersHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameValueWithParametersHeaderValue() { Pointer= p0 };

            value.Parameters                                = GetObjectList<NameValueHeaderValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.NameValueHeaderValue.FromPointer); // 02466B907C18 0x20 Parameters                  ( 000185CF5918 ModelClassListType List`1<NameValueHeaderValue> List`1<NameValueHeaderValue> List<NameValueHeaderValue> Pointer )

            return value;
        }
    }
}
