using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 IsShowFooter                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceIdolSelectPermanentData : DataModel
    {
        public int                                      UnitNumber                              { get; set; }
        public bool                                     IsShowFooter                            { get; set; }

        public static ProduceIdolSelectPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectPermanentData() { Pointer= p0 };

            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x010)); // 0245A3A77C58 0x10 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsShowFooter                              = GetBool(new IntPtr(p + 0x014)); // 0245A3A77C78 0x14 IsShowFooter                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
