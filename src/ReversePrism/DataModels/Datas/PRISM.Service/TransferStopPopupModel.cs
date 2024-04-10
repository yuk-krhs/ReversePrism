using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserId                                   000186671910 ModelPrimitiveType string string string String
    public partial class TransferStopPopupModel : DataModel
    {
        public string                                   UserId                                  { get; set; }

        public static TransferStopPopupModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferStopPopupModel() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x010)); // 0246667DDD30 0x10 UserId                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
