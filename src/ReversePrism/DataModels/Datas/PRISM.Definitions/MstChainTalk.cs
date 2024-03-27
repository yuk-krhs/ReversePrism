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
    public partial class MstChainTalk
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstChainGroupId                         { get; set; }

        public static MstChainTalk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainTalk();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700462AFE0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChainGroupId                           = GetInt32(new IntPtr(p + 0x014)); // 02700462B000 0x14 MstChainGroupId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
