using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ItemCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProducePreparationEpisodeSelectUnitListContext : DataModel
    {
        public int                                      ItemCount                               { get; set; }

        public static ProducePreparationEpisodeSelectUnitListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitListContext() { Pointer= p0 };

            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x038)); // 024665A56530 0x38 ItemCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
