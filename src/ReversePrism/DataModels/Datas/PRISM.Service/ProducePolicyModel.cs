using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeletedIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProducePolicyModel : DataModel
    {
        public int                                      SeletedIndex                            { get; set; }

        public static ProducePolicyModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyModel() { Pointer= p0 };

            value.SeletedIndex                              = GetInt32(new IntPtr(p + 0x010)); // 024666610B90 0x10 SeletedIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
