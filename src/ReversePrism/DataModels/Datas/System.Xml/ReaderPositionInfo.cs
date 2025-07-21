using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineInfo                                 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    public partial class ReaderPositionInfo : DataModel
    {
        public IXmlLineInfo?                            LineInfo                                { get; set; }

        public static ReaderPositionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderPositionInfo() { Pointer= p0 };

            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0x10 LineInfo                    ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )

            return value;
        }
    }
}
