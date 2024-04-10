using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsVoicePlayActive                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 FinishedStoryId                          00018665B7C0 ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer
    // 020 NextStoryId                              00018665B7C0 ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer
    // 028 StoryRewards                             000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class StoryToAdvTransitionerModel : DataModel
    {
        public bool                                     IsVoicePlayActive                       { get; set; }
        public IStoryIDStatus?                          FinishedStoryId                         { get; set; }
        public IStoryIDStatus?                          NextStoryId                             { get; set; }
        public List<IProductWithAmountStatus>?          StoryRewards                            { get; set; }

        public static StoryToAdvTransitionerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryToAdvTransitionerModel() { Pointer= p0 };

            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x010)); // 024665EAD2E0 0x10 IsVoicePlayActive           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FinishedStoryId                           = GetObject<IStoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoryIDStatus.FromPointer); // 024665EAD300 0x18 FinishedStoryId             ( 00018665B7C0 ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer )
            value.NextStoryId                               = GetObject<IStoryIDStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoryIDStatus.FromPointer); // 024665EAD320 0x20 NextStoryId                 ( 00018665B7C0 ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer )
            value.StoryRewards                              = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024665EAD340 0x28 StoryRewards                ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
