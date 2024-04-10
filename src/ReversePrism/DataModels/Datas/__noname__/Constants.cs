using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ContentTransferEncoding                  string IL2CPP_TYPE_STRING
    // 000 ContentID                                string IL2CPP_TYPE_STRING
    // 000 ContentType                              string IL2CPP_TYPE_STRING
    // 000 MimeVersion                              string IL2CPP_TYPE_STRING
    public partial class Constants : DataModel
    {

        public static Constants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Constants() { Pointer= p0 };


            return value;
        }
    }
}
