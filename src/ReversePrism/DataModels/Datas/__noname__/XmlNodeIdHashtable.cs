using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Id                                       000186749450 ModelClassType XmlNodeIdentety XmlNodeIdentety XmlNodeIdentety Pointer
    public partial class XmlNodeIdHashtable : DataModel
    {
        public XmlNodeIdentety?                         Id                                      { get; set; }

        public static XmlNodeIdHashtable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeIdHashtable() { Pointer= p0 };

            value.Id                                        = GetObject<XmlNodeIdentety>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNodeIdentety.FromPointer); // 0246689E4020 0x50 Id                          ( 000186749450 ModelClassType XmlNodeIdentety XmlNodeIdentety XmlNodeIdentety Pointer )

            return value;
        }
    }
}
