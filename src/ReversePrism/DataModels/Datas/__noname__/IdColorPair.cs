using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainGroupId                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ChainTalkColorType                       00018673EAE0 ModelEnumType ColorType ColorType ColorType Int32
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

            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x010)); // 02466B1756B0 0x10 ChainGroupId                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChainTalkColorType                        = (ColorType)GetInt32(new IntPtr(p + 0x014)); // 02466B1756D0 0x14 ChainTalkColorType          ( 00018673EAE0 ModelEnumType ColorType ColorType ColorType Int32 )

            return value;
        }
    }
}
