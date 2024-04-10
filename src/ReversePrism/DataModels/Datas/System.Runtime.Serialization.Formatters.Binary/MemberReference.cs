using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdRef                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class MemberReference : DataModel
    {
        public int                                      IdRef                                   { get; set; }

        public static MemberReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberReference() { Pointer= p0 };

            value.IdRef                                     = GetInt32(new IntPtr(p + 0x010)); // 024666CA3030 0x10 IdRef                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
