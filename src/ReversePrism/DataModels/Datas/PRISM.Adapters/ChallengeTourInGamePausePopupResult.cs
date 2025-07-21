using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRetry                                  ModelPrimitiveType bool bool bool Bool
    // 011 IsGiveUp                                 ModelPrimitiveType bool bool bool Bool
    // 018 OptionSaveData                           ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    public partial class ChallengeTourInGamePausePopupResult : DataModel
    {
        public bool                                     IsRetry                                 { get; set; }
        public bool                                     IsGiveUp                                { get; set; }
        public ProduceOptionSaveData?                   OptionSaveData                          { get; set; }

        public static ChallengeTourInGamePausePopupResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePausePopupResult() { Pointer= p0 };

            value.IsRetry                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 IsRetry                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsGiveUp                                  = GetBool(new IntPtr(p + 0x011)); // 0x11 IsGiveUp                    ( ModelPrimitiveType bool bool bool Bool )
            value.OptionSaveData                            = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0x18 OptionSaveData              ( ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
