using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PotentialSupportSkillContentView         000186770FA0 ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer
    // 028 SCharaEditSDCharaIconListView            0001866A7890 ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer
    public partial class SCharaEditPotentialSupportSkillContentView : DataModel
    {
        public PotentialSupportSkillContentView?        PotentialSupportSkillContentView        { get; set; }
        public SCharaEditSDCharaIconListView?           SCharaEditSDCharaIconListView           { get; set; }

        public static SCharaEditPotentialSupportSkillContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditPotentialSupportSkillContentView() { Pointer= p0 };

            value.PotentialSupportSkillContentView          = GetObject<PotentialSupportSkillContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PotentialSupportSkillContentView.FromPointer); // 02466B60BE88 0x20 PotentialSupportSkillContentView ( 000186770FA0 ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<SCharaEditSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSDCharaIconListView.FromPointer); // 02466B60BEA8 0x28 SCharaEditSDCharaIconListView ( 0001866A7890 ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer )

            return value;
        }
    }
}
