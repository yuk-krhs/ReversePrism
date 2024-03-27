using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Connections                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlDownloadManager
    {
        public Hashtable?                               Connections                             { get; set; }

        public static XmlDownloadManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDownloadManager();

            value.Connections                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D747F9D0 0x10 Connections                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
