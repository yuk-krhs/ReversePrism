using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 GrayOutCover                             ModelClassType GameObject GameObject GameObject Pointer
    // 048 RankUpPCardContent                       ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer
    // 050 PlusButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 058 MinusButton                              ModelClassType UIButton UIButton UIButton Pointer
    public partial class PCardRankUpGridCell : DataModel
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
            var value   = new PCardRankUpGridCell() { Pointer= p0 };

            value.GrayOutCover                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GrayOutCover                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RankUpPCardContent                        = GetObject<RankUpProduceCardContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.RankUpProduceCardContent.FromPointer); // 0x48 RankUpPCardContent          ( ModelClassType RankUpProduceCardContent RankUpProduceCardContent RankUpProduceCardContent Pointer )
            value.PlusButton                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 PlusButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MinusButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 MinusButton                 ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
