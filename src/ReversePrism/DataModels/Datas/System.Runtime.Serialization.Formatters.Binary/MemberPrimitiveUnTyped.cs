using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeInformation                          0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 018 value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class MemberPrimitiveUnTyped : DataModel
    {
        public InternalPrimitiveTypeE                   TypeInformation                         { get; set; }

        public static MemberPrimitiveUnTyped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberPrimitiveUnTyped() { Pointer= p0 };

            value.TypeInformation                           = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x010)); // 024666CA2D88 0x10 TypeInformation             ( 0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )

            return value;
        }
    }
}
