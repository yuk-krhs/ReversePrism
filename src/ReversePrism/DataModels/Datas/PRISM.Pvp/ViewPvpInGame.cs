using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 PvpInGamePresenter                       0001865E6AA0 ModelClassType PvpInGamePresenter PvpInGamePresenter PvpInGamePresenter Pointer
    // 088 PvpInGameView                            0001865E8B70 ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer
    // 090 ViewParam                                0001865E94F0 ModelClassType PvpInGameViewParam PvpInGameViewParam PvpInGameViewParam Pointer
    // 098 Random                                   0001866093D0 ModelClassType Random Random Random Pointer
    // 0A0 PvpMatchRewards                          000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 0A8 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.PvpInGamePresenter                        = GetObject<PvpInGamePresenter>(new IntPtr(p + 0x080), ReversePrism.DataModels.PvpInGamePresenter.FromPointer); // 0246650EC310 0x80 PvpInGamePresenter          ( 0001865E6AA0 ModelClassType PvpInGamePresenter PvpInGamePresenter PvpInGamePresenter Pointer )
            value.PvpInGameView                             = GetObject<PvpInGameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.PvpInGameView.FromPointer); // 0246650EC330 0x88 PvpInGameView               ( 0001865E8B70 ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer )
            value.ViewParam                                 = GetObject<PvpInGameViewParam>(new IntPtr(p + 0x090), ReversePrism.DataModels.PvpInGameViewParam.FromPointer); // 0246650EC350 0x90 ViewParam                   ( 0001865E94F0 ModelClassType PvpInGameViewParam PvpInGameViewParam PvpInGameViewParam Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x098), ReversePrism.DataModels.Random.FromPointer); // 0246650EC370 0x98 Random                      ( 0001866093D0 ModelClassType Random Random Random Pointer )
            value.PvpMatchRewards                           = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0246650EC390 0xA0 PvpMatchRewards             ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x0A8)); // 0246650EC3B0 0xA8 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
