using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ProducePolicyID                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C ProducePolicyTypeID                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LogAccordionOnProducePolicyViewModel : DataModel
    {
        public int                                      ProducePolicyID                         { get; set; }
        public int                                      ProducePolicyTypeID                     { get; set; }

        public static LogAccordionOnProducePolicyViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogAccordionOnProducePolicyViewModel() { Pointer= p0 };

            value.ProducePolicyID                           = GetInt32(new IntPtr(p + 0x018)); // 024666576810 0x18 ProducePolicyID             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProducePolicyTypeID                       = GetInt32(new IntPtr(p + 0x01C)); // 024666576830 0x1C ProducePolicyTypeID         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
