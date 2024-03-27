using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 m_TreeItems                              Dictionary`2<int, TreeItem> IL2CPP_TYPE_GENERICINST
    // 038 M_RootIndices                            000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 040 M_ItemWrappers                           000185D16408 ModelEnumListType List`1<TreeViewItemWrapper> List`1<TreeViewItemWrapper> List<TreeViewItemWrapper> Pointer
    // 048 m_TreeItemIdsWithItemWrappers            HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 050 M_WrapperInsertionList                   000185D16408 ModelEnumListType List`1<TreeViewItemWrapper> List`1<TreeViewItemWrapper> List<TreeViewItemWrapper> Pointer
    // 000 K_ExpandItemByIndex                      ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_CreateWrappers                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class BaseTreeViewController
    {
        public List<int>?                               M_RootIndices                           { get; set; }
        public List<TreeViewItemWrapper>?               M_ItemWrappers                          { get; set; }
        public List<TreeViewItemWrapper>?               M_WrapperInsertionList                  { get; set; }

        public static BaseTreeViewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseTreeViewController();

            value.M_RootIndices                             = GetInt32List(new IntPtr(p + 0x038)); // 0270066E77A0 0x38 M_RootIndices               ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_ItemWrappers                            = GetEnumList<TreeViewItemWrapper>(new IntPtr(p + 0x040)); // 0270066E77C0 0x40 M_ItemWrappers              ( 000185D16408 ModelEnumListType List`1<TreeViewItemWrapper> List`1<TreeViewItemWrapper> List<TreeViewItemWrapper> Pointer )
            value.M_WrapperInsertionList                    = GetEnumList<TreeViewItemWrapper>(new IntPtr(p + 0x050)); // 0270066E7800 0x50 M_WrapperInsertionList      ( 000185D16408 ModelEnumListType List`1<TreeViewItemWrapper> List`1<TreeViewItemWrapper> List<TreeViewItemWrapper> Pointer )

            return value;
        }
    }
}
