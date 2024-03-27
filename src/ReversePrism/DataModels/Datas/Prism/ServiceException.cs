using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Result                                   00018673A690 ModelEnumType ServiceResult ServiceResult ServiceResult Int32
    // 098 Error                                    0001865C0880 ModelClassType INetworkError INetworkError INetworkError Pointer
    public partial class ServiceException
    {
        public ServiceResult                            Result                                  { get; set; }
        public INetworkError?                           Error                                   { get; set; }

        public static ServiceException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceException();

            value.Result                                    = (ServiceResult)GetInt32(new IntPtr(p + 0x090)); // 0270D4C4B230 0x90 Result                      ( 00018673A690 ModelEnumType ServiceResult ServiceResult ServiceResult Int32 )
            value.Error                                     = GetObject<INetworkError>(new IntPtr(p + 0x098), ReversePrism.DataModels.INetworkError.FromPointer); // 0270D4C4B250 0x98 Error                       ( 0001865C0880 ModelClassType INetworkError INetworkError INetworkError Pointer )

            return value;
        }
    }
}
