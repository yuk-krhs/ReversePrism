using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 MaxCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1B4 CountedIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ClickNumberCountedButton
    {
        public int                                      MaxCount                                { get; set; }
        public int                                      CountedIndex                            { get; set; }

        public static ClickNumberCountedButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClickNumberCountedButton();

            value.MaxCount                                  = GetInt32(new IntPtr(p + 0x1B0)); // 0270D4C4D9C8 0x1B0 MaxCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CountedIndex                              = GetInt32(new IntPtr(p + 0x1B4)); // 0270D4C4D9E8 0x1B4 CountedIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
