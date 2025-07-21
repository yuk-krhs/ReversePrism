using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 GradeIcon                                ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer
    // 030 NoneObject                               ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveAllSongEventResultIdolCell : DataModel
    {
        public PFIdolIconView?                          Icon                                    { get; set; }
        public LiveEventRankingGradeIcon?               GradeIcon                               { get; set; }
        public GameObject?                              NoneObject                              { get; set; }

        public static LiveAllSongEventResultIdolCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveAllSongEventResultIdolCell() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 Icon                        ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.GradeIcon                                 = GetObject<LiveEventRankingGradeIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingGradeIcon.FromPointer); // 0x28 GradeIcon                   ( ModelClassType LiveEventRankingGradeIcon LiveEventRankingGradeIcon LiveEventRankingGradeIcon Pointer )
            value.NoneObject                                = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 NoneObject                  ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
