using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 itemUssClassName                         string IL2CPP_TYPE_STRING
    // 010 ItemToggleUssClassName                   000186674040 ModelPrimitiveType string string string String
    // 018 ItemIndentsContainerUssClassName         000186674040 ModelPrimitiveType string string string String
    // 020 ItemIndentUssClassName                   000186674040 ModelPrimitiveType string string string String
    // 028 ItemContentContainerUssClassName         000186674040 ModelPrimitiveType string string string String
    // 4B0 M_AutoExpand                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 4B8 M_ExpandedItemIds                        000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class BaseTreeView : DataModel
    {
        public string                                   ItemToggleUssClassName                  { get; set; }
        public string                                   ItemIndentsContainerUssClassName        { get; set; }
        public string                                   ItemIndentUssClassName                  { get; set; }
        public string                                   ItemContentContainerUssClassName        { get; set; }
        public bool                                     M_AutoExpand                            { get; set; }
        public List<int>?                               M_ExpandedItemIds                       { get; set; }

        public static BaseTreeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseTreeView() { Pointer= p0 };

            value.ItemToggleUssClassName                    = GetString(new IntPtr(p + 0x010)); // 0245A66BC7E0 0x10 ItemToggleUssClassName      ( 000186674040 ModelPrimitiveType string string string String )
            value.ItemIndentsContainerUssClassName          = GetString(new IntPtr(p + 0x018)); // 0245A66BC800 0x18 ItemIndentsContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ItemIndentUssClassName                    = GetString(new IntPtr(p + 0x020)); // 0245A66BC820 0x20 ItemIndentUssClassName      ( 000186674040 ModelPrimitiveType string string string String )
            value.ItemContentContainerUssClassName          = GetString(new IntPtr(p + 0x028)); // 0245A66BC840 0x28 ItemContentContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.M_AutoExpand                              = GetBool(new IntPtr(p + 0x4B0)); // 0245A66BC860 0x4B0 M_AutoExpand                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ExpandedItemIds                         = GetInt32List(new IntPtr(p + 0x4B8)); // 0245A66BC880 0x4B8 M_ExpandedItemIds           ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
