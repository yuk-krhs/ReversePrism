using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 SelfProfileContent                       0001865ED3E0 ModelClassType PvpPerformanceProfileContent PvpPerformanceProfileContent PvpPerformanceProfileContent Pointer
    // 038 OpponentProfileContent                   0001865ED3E0 ModelClassType PvpPerformanceProfileContent PvpPerformanceProfileContent PvpPerformanceProfileContent Pointer
    public partial class PvpPerformanceContent
    {
        public GameObject?                              RootObject                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public PvpPerformanceProfileContent?            SelfProfileContent                      { get; set; }
        public PvpPerformanceProfileContent?            OpponentProfileContent                  { get; set; }

        public static PvpPerformanceContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceContent();

            value.RootObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBF15760 0x20 RootObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0270DBF15780 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SelfProfileContent                        = GetObject<PvpPerformanceProfileContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpPerformanceProfileContent.FromPointer); // 0270DBF157A0 0x30 SelfProfileContent          ( 0001865ED3E0 ModelClassType PvpPerformanceProfileContent PvpPerformanceProfileContent PvpPerformanceProfileContent Pointer )
            value.OpponentProfileContent                    = GetObject<PvpPerformanceProfileContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpPerformanceProfileContent.FromPointer); // 0270DBF157C0 0x38 OpponentProfileContent      ( 0001865ED3E0 ModelClassType PvpPerformanceProfileContent PvpPerformanceProfileContent PvpPerformanceProfileContent Pointer )

            return value;
        }
    }
}
