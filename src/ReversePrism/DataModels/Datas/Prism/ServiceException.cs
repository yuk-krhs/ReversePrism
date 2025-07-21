using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Result                                   ModelEnumType ServiceResult ServiceResult ServiceResult Int32
    // 098 Error                                    ModelClassType INetworkError INetworkError INetworkError Pointer
    public partial class ServiceException : DataModel
    {
        public ServiceResult                            Result                                  { get; set; }
        public INetworkError?                           Error                                   { get; set; }

        public static ServiceException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceException() { Pointer= p0 };

            value.Result                                    = (ServiceResult)GetInt32(new IntPtr(p + 0x090)); // 0x90 Result                      ( ModelEnumType ServiceResult ServiceResult ServiceResult Int32 )
            value.Error                                     = GetObject<INetworkError>(new IntPtr(p + 0x098), ReversePrism.DataModels.INetworkError.FromPointer); // 0x98 Error                       ( ModelClassType INetworkError INetworkError INetworkError Pointer )

            return value;
        }
    }
}
