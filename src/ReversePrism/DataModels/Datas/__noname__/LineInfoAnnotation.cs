using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineNumber                               0001865F44E0 ModelPrimitiveType int int int Int32
    // 014 LinePosition                             0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class LineInfoAnnotation : DataModel
    {
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }

        public static LineInfoAnnotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LineInfoAnnotation() { Pointer= p0 };

            value.LineNumber                                = GetInt32(new IntPtr(p + 0x010)); // 024668879788 0x10 LineNumber                  ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x014)); // 0246688797A8 0x14 LinePosition                ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
