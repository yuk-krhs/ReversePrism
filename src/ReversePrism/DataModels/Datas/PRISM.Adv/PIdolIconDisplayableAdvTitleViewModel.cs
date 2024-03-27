using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseViewModel                            0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer
    // 018 MstProduceIdolId                         000186672F10 ModelPrimitiveType string string string String
    // 020 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class PIdolIconDisplayableAdvTitleViewModel
    {
        public AdvTitleViewModel?                       BaseViewModel                           { get; set; }
        public string                                   MstProduceIdolId                        { get; set; }
        public int                                      Rarity                                  { get; set; }

        public static PIdolIconDisplayableAdvTitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolIconDisplayableAdvTitleViewModel();

            value.BaseViewModel                             = GetObject<AdvTitleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvTitleViewModel.FromPointer); // 0270D5DD2FC0 0x10 BaseViewModel               ( 0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer )
            value.MstProduceIdolId                          = GetString(new IntPtr(p + 0x018)); // 0270D5DD2FE0 0x18 MstProduceIdolId            ( 000186672F10 ModelPrimitiveType string string string String )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D5DD3000 0x20 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
