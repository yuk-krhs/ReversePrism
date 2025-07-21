using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 PvpInGameView                            ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer
    // 088 PvpInGameModel                           ModelClassType PvpInGameModel PvpInGameModel PvpInGameModel Pointer
    // 090 <OnPreShowResultAsync>k__BackingField    Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
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

            value.PvpInGameView                             = GetObject<PvpInGameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.PvpInGameView.FromPointer); // 0x80 PvpInGameView               ( ModelClassType PvpInGameView PvpInGameView PvpInGameView Pointer )
            value.PvpInGameModel                            = GetObject<PvpInGameModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.PvpInGameModel.FromPointer); // 0x88 PvpInGameModel              ( ModelClassType PvpInGameModel PvpInGameModel PvpInGameModel Pointer )

            return value;
        }
    }
}
