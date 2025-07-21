using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                CriFsServer IL2CPP_TYPE_CLASS
    // 030 RequestList                              ModelClassListType List`1<CriFsRequest> List`1<CriFsRequest> List<CriFsRequest> Pointer
    // 038 InstallBufferSize                        ModelPrimitiveType int int int Int32
    public partial class CriFsServer : DataModel
    {
        public List<CriFsRequest>?                      RequestList                             { get; set; }
        public int                                      InstallBufferSize                       { get; set; }

        public static CriFsServer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsServer() { Pointer= p0 };

            value.RequestList                               = GetObjectList<CriFsRequest>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriFsRequest.FromPointer); // 0x30 RequestList                 ( ModelClassListType List`1<CriFsRequest> List`1<CriFsRequest> List<CriFsRequest> Pointer )
            value.InstallBufferSize                         = GetInt32(new IntPtr(p + 0x038)); // 0x38 InstallBufferSize           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
