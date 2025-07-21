using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Data                                     ModelClassType ResponseData ResponseData ResponseData Pointer
    public partial class GetUserResponse : DataModel
    {
        public ResponseData?                            Data                                    { get; set; }

        public static GetUserResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetUserResponse() { Pointer= p0 };

            value.Data                                      = GetObject<ResponseData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ResponseData.FromPointer); // 0x18 Data                        ( ModelClassType ResponseData ResponseData ResponseData Pointer )

            return value;
        }
    }
}
