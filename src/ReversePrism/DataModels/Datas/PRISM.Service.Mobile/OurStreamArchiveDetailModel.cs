using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    public partial class OurStreamArchiveDetailModel
    {
        public StreamProgramService?                    Service                                 { get; set; }

        public static OurStreamArchiveDetailModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailModel();

            value.Service                                   = GetObject<StreamProgramService>(new IntPtr(p + 0x010), ReversePrism.DataModels.StreamProgramService.FromPointer); // 0270D689FFF0 0x10 Service                     ( 0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )

            return value;
        }
    }
}
