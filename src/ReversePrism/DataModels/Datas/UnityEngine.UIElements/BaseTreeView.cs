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
    // 010 ItemToggleUssClassName                   ModelPrimitiveType string string string String
    // 018 ItemIndentsContainerUssClassName         ModelPrimitiveType string string string String
    // 020 ItemIndentUssClassName                   ModelPrimitiveType string string string String
    // 028 ItemContentContainerUssClassName         ModelPrimitiveType string string string String
    // 4B0 M_AutoExpand                             ModelPrimitiveType bool bool bool Bool
    // 4B8 M_ExpandedItemIds                        ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
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

            value.ItemToggleUssClassName                    = GetString(new IntPtr(p + 0x010)); // 0x10 ItemToggleUssClassName      ( ModelPrimitiveType string string string String )
            value.ItemIndentsContainerUssClassName          = GetString(new IntPtr(p + 0x018)); // 0x18 ItemIndentsContainerUssClassName ( ModelPrimitiveType string string string String )
            value.ItemIndentUssClassName                    = GetString(new IntPtr(p + 0x020)); // 0x20 ItemIndentUssClassName      ( ModelPrimitiveType string string string String )
            value.ItemContentContainerUssClassName          = GetString(new IntPtr(p + 0x028)); // 0x28 ItemContentContainerUssClassName ( ModelPrimitiveType string string string String )
            value.M_AutoExpand                              = GetBool(new IntPtr(p + 0x4B0)); // 0x4B0 M_AutoExpand                ( ModelPrimitiveType bool bool bool Bool )
            value.M_ExpandedItemIds                         = GetInt32List(new IntPtr(p + 0x4B8)); // 0x4B8 M_ExpandedItemIds           ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
