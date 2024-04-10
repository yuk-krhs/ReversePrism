using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_prism_Container             Marshaller`1<Container> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_google_protobuf_Empty       Marshaller`1<Empty> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_prism_CreateArchiveIndexRequest Marshaller`1<CreateArchiveIndexRequest> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_prism_ListArchiveIndexResponse Marshaller`1<ListArchiveIndexResponse> IL2CPP_TYPE_GENERICINST
    // 028 __Method_CreateContainerChunk            Method`2<Container, Empty> IL2CPP_TYPE_GENERICINST
    // 030 __Method_CreateArchiveIndex              Method`2<CreateArchiveIndexRequest, Empty> IL2CPP_TYPE_GENERICINST
    // 038 __Method_ListArchiveIndex                Method`2<Empty, ListArchiveIndexResponse> IL2CPP_TYPE_GENERICINST
    public partial class IngestService : DataModel
    {

        public static IngestService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngestService() { Pointer= p0 };


            return value;
        }
    }
}
