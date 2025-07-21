using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Serializer                             ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer
    public partial class StreamingAssetsConfigurationLoader : DataModel
    {
        public IJsonSerializer?                         M_Serializer                            { get; set; }

        public static StreamingAssetsConfigurationLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingAssetsConfigurationLoader() { Pointer= p0 };

            value.M_Serializer                              = GetObject<IJsonSerializer>(new IntPtr(p + 0x010), ReversePrism.DataModels.IJsonSerializer.FromPointer); // 0x10 M_Serializer                ( ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer )

            return value;
        }
    }
}
