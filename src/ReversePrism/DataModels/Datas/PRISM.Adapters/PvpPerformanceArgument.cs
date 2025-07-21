using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PvpMatch                                 ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer
    // 018 SelfProfileViewModel                     ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer
    // 020 OpponentProfileViewModel                 ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer
    public partial class PvpPerformanceArgument : DataModel
    {
        public IPvpMatchStatus?                         PvpMatch                                { get; set; }
        public PvpPerformanceProfileViewModel?          SelfProfileViewModel                    { get; set; }
        public PvpPerformanceProfileViewModel?          OpponentProfileViewModel                { get; set; }

        public static PvpPerformanceArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceArgument() { Pointer= p0 };

            value.PvpMatch                                  = GetObject<IPvpMatchStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpMatchStatus.FromPointer); // 0x10 PvpMatch                    ( ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer )
            value.SelfProfileViewModel                      = GetObject<PvpPerformanceProfileViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpPerformanceProfileViewModel.FromPointer); // 0x18 SelfProfileViewModel        ( ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer )
            value.OpponentProfileViewModel                  = GetObject<PvpPerformanceProfileViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPerformanceProfileViewModel.FromPointer); // 0x20 OpponentProfileViewModel    ( ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer )

            return value;
        }
    }
}
