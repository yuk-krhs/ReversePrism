using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 PvpInGameView                            0001865E9030 ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer
    // 078 PvpInGameModel                           0001865E5EB0 ModelClassType PvpInGameModel PvpInGameModel PvpInGameModel Pointer
    // 080 <OnPreShowResultAsync>k__BackingField    Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    public partial class PvpInGamePresenter : DataModel
    {
        public PvpInGameView?                           PvpInGameView                           { get; set; }
        public PvpInGameModel?                          PvpInGameModel                          { get; set; }

        public static PvpInGamePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGamePresenter() { Pointer= p0 };

            value.PvpInGameView                             = GetObject<PvpInGameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PvpInGameView.FromPointer); // 0246650DCCF0 0x70 PvpInGameView               ( 0001865E9030 ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer )
            value.PvpInGameModel                            = GetObject<PvpInGameModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.PvpInGameModel.FromPointer); // 0246650DCD10 0x78 PvpInGameModel              ( 0001865E5EB0 ModelClassType PvpInGameModel PvpInGameModel PvpInGameModel Pointer )

            return value;
        }
    }
}
