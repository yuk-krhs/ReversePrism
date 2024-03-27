using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 METADATA_KEY                             string IL2CPP_TYPE_STRING
    public partial class MetadataBuilder
    {

        public static MetadataBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetadataBuilder();


            return value;
        }
    }
}
