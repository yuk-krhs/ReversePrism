using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveSkillInfoViewModels                  ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer
    public partial class ProduceIdolLiveSkillViewModel : DataModel
    {
        public List<PotentialLiveSkillInfoViewModel>?   LiveSkillInfoViewModels                 { get; set; }

        public static ProduceIdolLiveSkillViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolLiveSkillViewModel() { Pointer= p0 };

            value.LiveSkillInfoViewModels                   = GetObjectList<PotentialLiveSkillInfoViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.PotentialLiveSkillInfoViewModel.FromPointer); // 0x10 LiveSkillInfoViewModels     ( ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer )

            return value;
        }
    }
}
