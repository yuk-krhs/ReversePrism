using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_prism_GetContainerChunkRequest Marshaller`1<GetContainerChunkRequest> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_prism_Container             Marshaller`1<Container> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetContainerChunk               Method`2<GetContainerChunkRequest, Container> IL2CPP_TYPE_GENERICINST
    public partial class OutgestService
    {

        public static OutgestService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutgestService();


            return value;
        }
    }
}
