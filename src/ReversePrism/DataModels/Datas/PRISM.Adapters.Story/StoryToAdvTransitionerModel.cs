using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsVoicePlayActive                        ModelPrimitiveType bool bool bool Bool
    // 018 NextStoryId                              ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer
    // 020 StoryRewards                             ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 028 FinishAdvTcs                             ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer
    public partial class StoryToAdvTransitionerModel : DataModel
    {
        public bool                                     IsVoicePlayActive                       { get; set; }
        public IStoryIDStatus?                          NextStoryId                             { get; set; }
        public List<IProductWithAmountStatus>?          StoryRewards                            { get; set; }
        public UniTaskCompletionSource?                 FinishAdvTcs                            { get; set; }

        public static StoryToAdvTransitionerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryToAdvTransitionerModel() { Pointer= p0 };

            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x010)); // 0x10 IsVoicePlayActive           ( ModelPrimitiveType bool bool bool Bool )
            value.NextStoryId                               = GetObject<IStoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoryIDStatus.FromPointer); // 0x18 NextStoryId                 ( ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer )
            value.StoryRewards                              = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x20 StoryRewards                ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.FinishAdvTcs                              = GetObject<UniTaskCompletionSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.UniTaskCompletionSource.FromPointer); // 0x28 FinishAdvTcs                ( ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer )

            return value;
        }
    }
}
