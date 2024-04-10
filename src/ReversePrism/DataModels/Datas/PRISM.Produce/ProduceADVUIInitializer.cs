using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvChoiceButtonGroupViewModel            000186694210 ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer
    // 018 CurrentPlayableADVView                   00018674CC30 ModelClassType PlayableADV PlayableADV PlayableADV Pointer
    // 020 IsAdv                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceADVUIInitializer : DataModel
    {
        public AdvChoiceButtonGroupViewModel?           AdvChoiceButtonGroupViewModel           { get; set; }
        public PlayableADV?                             CurrentPlayableADVView                  { get; set; }
        public bool                                     IsAdv                                   { get; set; }

        public static ProduceADVUIInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceADVUIInitializer() { Pointer= p0 };

            value.AdvChoiceButtonGroupViewModel             = GetObject<AdvChoiceButtonGroupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvChoiceButtonGroupViewModel.FromPointer); // 0245A65D43F8 0x10 AdvChoiceButtonGroupViewModel ( 000186694210 ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer )
            value.CurrentPlayableADVView                    = GetObject<PlayableADV>(new IntPtr(p + 0x018), ReversePrism.DataModels.PlayableADV.FromPointer); // 0245A65D4418 0x18 CurrentPlayableADVView      ( 00018674CC30 ModelClassType PlayableADV PlayableADV PlayableADV Pointer )
            value.IsAdv                                     = GetBool(new IntPtr(p + 0x020)); // 0245A65D4438 0x20 IsAdv                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
