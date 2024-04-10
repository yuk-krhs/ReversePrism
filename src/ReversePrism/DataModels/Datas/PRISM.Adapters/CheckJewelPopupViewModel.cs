using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaidJewelNum                             0001865F7700 ModelPrimitiveType long long long Int64
    // 018 FreeJewelNum                             0001865F7700 ModelPrimitiveType long long long Int64
    public partial class CheckJewelPopupViewModel : DataModel
    {
        public long                                     PaidJewelNum                            { get; set; }
        public long                                     FreeJewelNum                            { get; set; }

        public static CheckJewelPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CheckJewelPopupViewModel() { Pointer= p0 };

            value.PaidJewelNum                              = GetInt64(new IntPtr(p + 0x010)); // 0246663C1550 0x10 PaidJewelNum                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.FreeJewelNum                              = GetInt64(new IntPtr(p + 0x018)); // 0246663C1570 0x18 FreeJewelNum                ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
