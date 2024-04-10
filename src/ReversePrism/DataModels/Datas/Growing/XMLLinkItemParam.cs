using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParamList                                000185D1D808 ModelClassListType List`1<XMLTextItemParam> List`1<XMLTextItemParam> List<XMLTextItemParam> Pointer
    public partial class XMLLinkItemParam : DataModel
    {
        public List<XMLTextItemParam>?                  ParamList                               { get; set; }

        public static XMLLinkItemParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLLinkItemParam() { Pointer= p0 };

            value.ParamList                                 = GetObjectList<XMLTextItemParam>(new IntPtr(p + 0x020), ReversePrism.DataModels.XMLTextItemParam.FromPointer); // 024664BBE468 0x20 ParamList                   ( 000185D1D808 ModelClassListType List`1<XMLTextItemParam> List`1<XMLTextItemParam> List<XMLTextItemParam> Pointer )

            return value;
        }
    }
}
