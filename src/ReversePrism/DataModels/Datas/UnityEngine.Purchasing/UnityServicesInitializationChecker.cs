using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UgsUninitializedMessage                  string IL2CPP_TYPE_STRING
    // 010 M_Logger                                 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer
    public partial class UnityServicesInitializationChecker
    {
        public ILogger?                                 M_Logger                                { get; set; }

        public static UnityServicesInitializationChecker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityServicesInitializationChecker();

            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogger.FromPointer); // 027004BD9978 0x10 M_Logger                    ( 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer )

            return value;
        }
    }
}
