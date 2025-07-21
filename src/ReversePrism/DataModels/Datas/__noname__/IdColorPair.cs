using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainGroupId                             ModelPrimitiveType int int int Int32
    // 014 ChainTalkColorType                       ModelEnumType ColorType ColorType ColorType Int32
    public partial class IdColorPair : DataModel
    {
        public int                                      ChainGroupId                            { get; set; }
        public ColorType                                ChainTalkColorType                      { get; set; }

        public static IdColorPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdColorPair() { Pointer= p0 };

            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChainGroupId                ( ModelPrimitiveType int int int Int32 )
            value.ChainTalkColorType                        = (ColorType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ChainTalkColorType          ( ModelEnumType ColorType ColorType ColorType Int32 )

            return value;
        }
    }
}
