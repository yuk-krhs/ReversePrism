using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 PvpInGamePresenter                       ModelClassType PvpInGamePresenter PvpInGamePresenter PvpInGamePresenter Pointer
    // 080 PvpInGameView                            ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer
    // 088 ViewParam                                ModelClassType PvpInGameViewParam PvpInGameViewParam PvpInGameViewParam Pointer
    // 090 Random                                   ModelClassType Random Random Random Pointer
    // 098 PvpMatchRewards                          ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 0A0 EventId                                  ModelPrimitiveType int int int Int32
    public partial class ViewPvpInGame : DataModel
    {
        public PvpInGamePresenter?                      PvpInGamePresenter                      { get; set; }
        public PvpInGameView?                           PvpInGameView                           { get; set; }
        public PvpInGameViewParam?                      ViewParam                               { get; set; }
        public Random?                                  Random                                  { get; set; }
        public List<IProductWithAmountStatus>?          PvpMatchRewards                         { get; set; }
        public int                                      EventId                                 { get; set; }

        public static ViewPvpInGame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewPvpInGame() { Pointer= p0 };

            value.PvpInGamePresenter                        = GetObject<PvpInGamePresenter>(new IntPtr(p + 0x078), ReversePrism.DataModels.PvpInGamePresenter.FromPointer); // 0x78 PvpInGamePresenter          ( ModelClassType PvpInGamePresenter PvpInGamePresenter PvpInGamePresenter Pointer )
            value.PvpInGameView                             = GetObject<PvpInGameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.PvpInGameView.FromPointer); // 0x80 PvpInGameView               ( ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer )
            value.ViewParam                                 = GetObject<PvpInGameViewParam>(new IntPtr(p + 0x088), ReversePrism.DataModels.PvpInGameViewParam.FromPointer); // 0x88 ViewParam                   ( ModelClassType PvpInGameViewParam PvpInGameViewParam PvpInGameViewParam Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x090), ReversePrism.DataModels.Random.FromPointer); // 0x90 Random                      ( ModelClassType Random Random Random Pointer )
            value.PvpMatchRewards                           = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x98 PvpMatchRewards             ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 EventId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
