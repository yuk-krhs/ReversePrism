using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineInfo                                 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    public partial class ReaderPositionInfo
    {
        public IXmlLineInfo?                            LineInfo                                { get; set; }

        public static ReaderPositionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderPositionInfo();

            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0270D7472918 0x10 LineInfo                    ( 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )

            return value;
        }
    }
}
