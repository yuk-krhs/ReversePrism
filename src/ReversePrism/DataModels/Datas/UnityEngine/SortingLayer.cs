using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Id                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SortingLayer
    {
        public int                                      M_Id                                    { get; set; }

        public static SortingLayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortingLayer();

            value.M_Id                                      = GetInt32(new IntPtr(p + 0x010)); // 0270068A6798 0x10 M_Id                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
