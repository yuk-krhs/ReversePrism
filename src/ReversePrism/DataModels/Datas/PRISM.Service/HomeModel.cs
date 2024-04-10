using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 iconNameList                             HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 018 IsProducing                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HomeModel : DataModel
    {
        public bool                                     IsProducing                             { get; set; }

        public static HomeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeModel() { Pointer= p0 };

            value.IsProducing                               = GetBool(new IntPtr(p + 0x018)); // 0245A5B3C928 0x18 IsProducing                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
