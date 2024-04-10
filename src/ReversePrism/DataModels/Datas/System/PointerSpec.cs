using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pointer_level                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PointerSpec : DataModel
    {
        public int                                      Pointer_level                           { get; set; }

        public static PointerSpec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerSpec() { Pointer= p0 };

            value.Pointer_level                             = GetInt32(new IntPtr(p + 0x010)); // 024666B09618 0x10 Pointer_level               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
