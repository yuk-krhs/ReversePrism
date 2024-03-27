using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Errors                                   000185CBAFC8 ModelClassListType ResponseError[] ResponseError[] List<ResponseError> Pointer
    public partial class GraphResponse
    {
        public List<ResponseError>?                     Errors                                  { get; set; }

        public static GraphResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphResponse();

            value.Errors                                    = GetObjectList<ResponseError>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResponseError.FromPointer); // 0270DBDC0CB8 0x10 Errors                      ( 000185CBAFC8 ModelClassListType ResponseError[] ResponseError[] List<ResponseError> Pointer )

            return value;
        }
    }
}
