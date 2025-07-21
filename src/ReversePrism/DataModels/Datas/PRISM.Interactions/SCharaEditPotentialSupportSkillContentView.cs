using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PotentialSupportSkillContentView         ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer
    // 028 SCharaEditSDCharaIconListView            ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer
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

            value.PotentialSupportSkillContentView          = GetObject<PotentialSupportSkillContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PotentialSupportSkillContentView.FromPointer); // 0x20 PotentialSupportSkillContentView ( ModelClassType PotentialSupportSkillContentView PotentialSupportSkillContentView PotentialSupportSkillContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<SCharaEditSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSDCharaIconListView.FromPointer); // 0x28 SCharaEditSDCharaIconListView ( ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer )

            return value;
        }
    }
}
