using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RewardItem                               000186625810 ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer
    // 048 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 050 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class SpecialMissionCompleteRewardListViewCell : DataModel
    {
        public ReceiveRewardItem?                       RewardItem                              { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static SpecialMissionCompleteRewardListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionCompleteRewardListViewCell() { Pointer= p0 };

            value.RewardItem                                = GetObject<ReceiveRewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ReceiveRewardItem.FromPointer); // 02466BDDB200 0x40 RewardItem                  ( 000186625810 ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 02466BDDB220 0x48 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 02466BDDB240 0x50 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
