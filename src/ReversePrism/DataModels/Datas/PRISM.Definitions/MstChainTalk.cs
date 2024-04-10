using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstChainGroupId                          0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstChainTalk : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstChainGroupId                         { get; set; }

        public static MstChainTalk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainTalk() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46A6908 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChainGroupId                           = GetInt32(new IntPtr(p + 0x014)); // 0245A46A6928 0x14 MstChainGroupId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
