using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArchiveId                                0001865F4260 ModelPrimitiveType int int int Int32
    public partial class OurStreamArchiveDetailParameter : DataModel
    {
        public int                                      ArchiveId                               { get; set; }

        public static OurStreamArchiveDetailParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailParameter() { Pointer= p0 };

            value.ArchiveId                                 = GetInt32(new IntPtr(p + 0x010)); // 0246668FEFD8 0x10 ArchiveId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
