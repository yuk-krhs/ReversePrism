using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizeType                                 00018658C690 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 018 HeaderParameter                          00018658D9B0 ModelClassType HeaderInfoParameter HeaderInfoParameter HeaderInfoParameter Pointer
    // 020 FooterParameter                          00018658D480 ModelClassType FooterInfoParameter FooterInfoParameter FooterInfoParameter Pointer
    // 028 OutOfRangeParameter                      00018658DEB0 ModelClassType OutOfRangeInfoParameter OutOfRangeInfoParameter OutOfRangeInfoParameter Pointer
    // 030 OpenSE                                   0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 CloseSE                                  0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class PopupFrameParameter
    {
        public PopupSizeType                            SizeType                                { get; set; }
        public HeaderInfoParameter?                     HeaderParameter                         { get; set; }
        public FooterInfoParameter?                     FooterParameter                         { get; set; }
        public OutOfRangeInfoParameter?                 OutOfRangeParameter                     { get; set; }
        public SoundKey                                 OpenSE                                  { get; set; }
        public SoundKey                                 CloseSE                                 { get; set; }

        public static PopupFrameParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupFrameParameter();

            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x010)); // 0270DA0CDBF0 0x10 SizeType                    ( 00018658C690 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.HeaderParameter                           = GetObject<HeaderInfoParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.HeaderInfoParameter.FromPointer); // 0270DA0CDC10 0x18 HeaderParameter             ( 00018658D9B0 ModelClassType HeaderInfoParameter HeaderInfoParameter HeaderInfoParameter Pointer )
            value.FooterParameter                           = GetObject<FooterInfoParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.FooterInfoParameter.FromPointer); // 0270DA0CDC30 0x20 FooterParameter             ( 00018658D480 ModelClassType FooterInfoParameter FooterInfoParameter FooterInfoParameter Pointer )
            value.OutOfRangeParameter                       = GetObject<OutOfRangeInfoParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.OutOfRangeInfoParameter.FromPointer); // 0270DA0CDC50 0x28 OutOfRangeParameter         ( 00018658DEB0 ModelClassType OutOfRangeInfoParameter OutOfRangeInfoParameter OutOfRangeInfoParameter Pointer )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0270DA0CDC70 0x30 OpenSE                      ( 0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0270DA0CDC90 0x40 CloseSE                     ( 0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
