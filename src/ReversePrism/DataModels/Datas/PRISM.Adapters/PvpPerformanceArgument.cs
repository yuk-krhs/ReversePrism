using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PvpMatch                                 000186607960 ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer
    // 018 SelfProfileViewModel                     0001865EDD20 ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer
    // 020 OpponentProfileViewModel                 0001865EDD20 ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer
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

            value.PvpMatch                                  = GetObject<IPvpMatchStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpMatchStatus.FromPointer); // 02466672A208 0x10 PvpMatch                    ( 000186607960 ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer )
            value.SelfProfileViewModel                      = GetObject<PvpPerformanceProfileViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpPerformanceProfileViewModel.FromPointer); // 02466672A228 0x18 SelfProfileViewModel        ( 0001865EDD20 ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer )
            value.OpponentProfileViewModel                  = GetObject<PvpPerformanceProfileViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPerformanceProfileViewModel.FromPointer); // 02466672A248 0x20 OpponentProfileViewModel    ( 0001865EDD20 ModelClassType PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel PvpPerformanceProfileViewModel Pointer )

            return value;
        }
    }
}
