using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Data                                     0001865338E0 ModelClassType ResponseData ResponseData ResponseData Pointer
    public partial class CreateAppTokenResponse
    {
        public ResponseData?                            Data                                    { get; set; }

        public static CreateAppTokenResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateAppTokenResponse();

            value.Data                                      = GetObject<ResponseData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ResponseData.FromPointer); // 0270DBDC0CD8 0x18 Data                        ( 0001865338E0 ModelClassType ResponseData ResponseData ResponseData Pointer )

            return value;
        }
    }
}
