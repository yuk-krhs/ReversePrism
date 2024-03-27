using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RequestModel                             00018663E2C0 ModelEnumType CreateRequestModel CreateRequestModel CreateRequestModel Int32
    public partial class CreateReceipt
    {
        public CreateRequestModel                       RequestModel                            { get; set; }

        public static CreateReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateReceipt();

            value.RequestModel                              = (CreateRequestModel)GetInt32(new IntPtr(p + 0x038)); // 0270DB47A680 0x38 RequestModel                ( 00018663E2C0 ModelEnumType CreateRequestModel CreateRequestModel CreateRequestModel Int32 )

            return value;
        }
    }
}
