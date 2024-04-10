using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Users                                    000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 018 IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Choice                                   000185CF21A8 ModelClassListType IReadOnlyList`1<IChainChoiceStatus> IReadOnlyList`1<IChainChoiceStatus> List<IChainChoiceStatus> Pointer
    // 028 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 GroupType                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 ChainTalkTextList                        000185CF25D8 ModelClassListType IReadOnlyList`1<IChainTalkTextStatus> IReadOnlyList`1<IChainTalkTextStatus> List<IChainTalkTextStatus> Pointer
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

            value.Users                                     = GetInt32List(new IntPtr(p + 0x010)); // 0245A5F44110 0x10 Users                       ( 000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x018)); // 0245A5F44130 0x18 IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Choice                                    = GetObjectList<IChainChoiceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IChainChoiceStatus.FromPointer); // 0245A5F44150 0x20 Choice                      ( 000185CF21A8 ModelClassListType IReadOnlyList`1<IChainChoiceStatus> IReadOnlyList`1<IChainChoiceStatus> List<IChainChoiceStatus> Pointer )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x028)); // 0245A5F44170 0x28 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GroupType                                 = GetInt32(new IntPtr(p + 0x038)); // 0245A5F44190 0x38 GroupType                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChainTalkTextList                         = GetObjectList<IChainTalkTextStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IChainTalkTextStatus.FromPointer); // 0245A5F441B0 0x40 ChainTalkTextList           ( 000185CF25D8 ModelClassListType IReadOnlyList`1<IChainTalkTextStatus> IReadOnlyList`1<IChainTalkTextStatus> List<IChainTalkTextStatus> Pointer )

            return value;
        }
    }
}
