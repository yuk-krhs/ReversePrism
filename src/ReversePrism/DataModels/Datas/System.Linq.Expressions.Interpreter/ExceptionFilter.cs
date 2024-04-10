using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LabelIndex                               0001865F4940 ModelPrimitiveType int int int Int32
    // 014 StartIndex                               0001865F4940 ModelPrimitiveType int int int Int32
    // 018 EndIndex                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ExceptionFilter : DataModel
    {
        public int                                      LabelIndex                              { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      EndIndex                                { get; set; }

        public static ExceptionFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionFilter() { Pointer= p0 };

            value.LabelIndex                                = GetInt32(new IntPtr(p + 0x010)); // 02466A05A8D0 0x10 LabelIndex                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x014)); // 02466A05A8F0 0x14 StartIndex                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x018)); // 02466A05A910 0x18 EndIndex                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
