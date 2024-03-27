using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 GrayOutCover                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 RankUpPCardContent                       00018660D7C0 ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer
    // 050 PlusButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 MinusButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class PCardRankUpGridCell
    {
        public GameObject?                              GrayOutCover                            { get; set; }
        public RankUpProduceCardContent?                RankUpPCardContent                      { get; set; }
        public UIButton?                                PlusButton                              { get; set; }
        public UIButton?                                MinusButton                             { get; set; }

        public static PCardRankUpGridCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpGridCell();

            value.GrayOutCover                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CE9B88 0x40 GrayOutCover                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RankUpPCardContent                        = GetObject<RankUpProduceCardContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.RankUpProduceCardContent.FromPointer); // 0270D5CE9BA8 0x48 RankUpPCardContent          ( 00018660D7C0 ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer )
            value.PlusButton                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5CE9BC8 0x50 PlusButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MinusButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5CE9BE8 0x58 MinusButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
