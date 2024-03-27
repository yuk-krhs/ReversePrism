using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChallengeTourUnitViewModels              000185B74B70 ModelClassListType ChallengeTourUnitViewModel[] ChallengeTourUnitViewModel[] List<ChallengeTourUnitViewModel> Pointer
    // 018 StageFilterFlags                         000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 020 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 NewChallengeTourIds                      000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ChallengeTourTopViewModel
    {
        public List<ChallengeTourUnitViewModel>?        ChallengeTourUnitViewModels             { get; set; }
        public List<bool>?                              StageFilterFlags                        { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public List<int>?                               NewChallengeTourIds                     { get; set; }

        public static ChallengeTourTopViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopViewModel();

            value.ChallengeTourUnitViewModels               = GetObjectList<ChallengeTourUnitViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0270D64B8540 0x10 ChallengeTourUnitViewModels ( 000185B74B70 ModelClassListType ChallengeTourUnitViewModel[] ChallengeTourUnitViewModel[] List<ChallengeTourUnitViewModel> Pointer )
            value.StageFilterFlags                          = GetBoolList(new IntPtr(p + 0x018)); // 0270D64B8560 0x18 StageFilterFlags            ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x020)); // 0270D64B8580 0x20 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NewChallengeTourIds                       = GetInt32List(new IntPtr(p + 0x028)); // 0270D64B85A0 0x28 NewChallengeTourIds         ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
