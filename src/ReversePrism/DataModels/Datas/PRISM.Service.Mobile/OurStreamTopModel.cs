using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    public partial class OurStreamTopModel : DataModel
    {
        public StreamProgramService?                    Service                                 { get; set; }

        public static OurStreamTopModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopModel() { Pointer= p0 };

            value.Service                                   = GetObject<StreamProgramService>(new IntPtr(p + 0x010), ReversePrism.DataModels.StreamProgramService.FromPointer); // 024666930A88 0x10 Service                     ( 0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )

            return value;
        }
    }
}
