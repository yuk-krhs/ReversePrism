using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Users                                    ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 018 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 020 Choice                                   ModelClassListType IReadOnlyList`1<IChainChoiceStatus> IReadOnlyList`1<IChainChoiceStatus> List<IChainChoiceStatus> Pointer
    // 028 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 GroupType                                ModelPrimitiveType int int int Int32
    // 040 ChainTalkTextList                        ModelClassListType IReadOnlyList`1<IChainTalkTextStatus> IReadOnlyList`1<IChainTalkTextStatus> List<IChainTalkTextStatus> Pointer
    // 048 <LocalSelectedChainTalkTextIds>k__BackingField HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChainTalk : DataModel
    {
        public List<int>?                               Users                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public List<IChainChoiceStatus>?                Choice                                  { get; set; }
        public DateTime                                 PostDate                                { get; set; }
        public int                                      GroupType                               { get; set; }
        public List<IChainTalkTextStatus>?              ChainTalkTextList                       { get; set; }

        public static ChainTalk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalk() { Pointer= p0 };

            value.Users                                     = GetInt32List(new IntPtr(p + 0x010)); // 0x10 Users                       ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.Choice                                    = GetObjectList<IChainChoiceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IChainChoiceStatus.FromPointer); // 0x20 Choice                      ( ModelClassListType IReadOnlyList`1<IChainChoiceStatus> IReadOnlyList`1<IChainChoiceStatus> List<IChainChoiceStatus> Pointer )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x028)); // 0x28 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GroupType                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 GroupType                   ( ModelPrimitiveType int int int Int32 )
            value.ChainTalkTextList                         = GetObjectList<IChainTalkTextStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IChainTalkTextStatus.FromPointer); // 0x40 ChainTalkTextList           ( ModelClassListType IReadOnlyList`1<IChainTalkTextStatus> IReadOnlyList`1<IChainTalkTextStatus> List<IChainTalkTextStatus> Pointer )

            return value;
        }
    }
}
