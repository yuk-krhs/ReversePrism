using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vec3 Vec3 Vec3 Int32
    // 020 Data                                     <object> IL2CPP_TYPE_OBJECT
    public partial class ContourVertex : DataModel
    {
        public Vec3                                     Position                                { get; set; }

        public static ContourVertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContourVertex() { Pointer= p0 };

            value.Position                                  = (Vec3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vec3 Vec3 Vec3 Int32 )

            return value;
        }
    }
}
