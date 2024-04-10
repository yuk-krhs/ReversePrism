using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayOrder                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LogAccordionOnCommonViewModel : DataModel
    {
        public int                                      DisplayOrder                            { get; set; }

        public static LogAccordionOnCommonViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogAccordionOnCommonViewModel() { Pointer= p0 };

            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x010)); // 0246665743A8 0x10 DisplayOrder                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
