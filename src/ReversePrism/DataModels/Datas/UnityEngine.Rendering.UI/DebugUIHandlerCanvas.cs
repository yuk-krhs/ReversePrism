using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_DebugTreeState                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 m_PrefabsMap                             Dictionary`2<Type, Transform> IL2CPP_TYPE_GENERICINST
    // 030 PanelPrefab                              0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 038 Prefabs                                  000185CD7528 ModelClassListType List`1<DebugUIPrefabBundle> List`1<DebugUIPrefabBundle> List<DebugUIPrefabBundle> Pointer
    // 040 M_UIPanels                               000185CD6EC8 ModelClassListType List`1<DebugUIHandlerPanel> List`1<DebugUIHandlerPanel> List<DebugUIHandlerPanel> Pointer
    // 048 M_SelectedPanel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_SelectedWidget                         0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 058 M_CurrentQueryPath                       000186671910 ModelPrimitiveType string string string String
    public partial class DebugUIHandlerCanvas : DataModel
    {
        public int                                      M_DebugTreeState                        { get; set; }
        public Transform?                               PanelPrefab                             { get; set; }
        public List<DebugUIPrefabBundle>?               Prefabs                                 { get; set; }
        public List<DebugUIHandlerPanel>?               M_UIPanels                              { get; set; }
        public int                                      M_SelectedPanel                         { get; set; }
        public DebugUIHandlerWidget?                    M_SelectedWidget                        { get; set; }
        public string                                   M_CurrentQueryPath                      { get; set; }

        public static DebugUIHandlerCanvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerCanvas() { Pointer= p0 };

            value.M_DebugTreeState                          = GetInt32(new IntPtr(p + 0x020)); // 0246691CD7A8 0x20 M_DebugTreeState            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PanelPrefab                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0246691CD7E8 0x30 PanelPrefab                 ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.Prefabs                                   = GetObjectList<DebugUIPrefabBundle>(new IntPtr(p + 0x038), ReversePrism.DataModels.DebugUIPrefabBundle.FromPointer); // 0246691CD808 0x38 Prefabs                     ( 000185CD7528 ModelClassListType List`1<DebugUIPrefabBundle> List`1<DebugUIPrefabBundle> List<DebugUIPrefabBundle> Pointer )
            value.M_UIPanels                                = GetObjectList<DebugUIHandlerPanel>(new IntPtr(p + 0x040), ReversePrism.DataModels.DebugUIHandlerPanel.FromPointer); // 0246691CD828 0x40 M_UIPanels                  ( 000185CD6EC8 ModelClassListType List`1<DebugUIHandlerPanel> List`1<DebugUIHandlerPanel> List<DebugUIHandlerPanel> Pointer )
            value.M_SelectedPanel                           = GetInt32(new IntPtr(p + 0x048)); // 0246691CD848 0x48 M_SelectedPanel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SelectedWidget                          = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x050), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0246691CD868 0x50 M_SelectedWidget            ( 0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.M_CurrentQueryPath                        = GetString(new IntPtr(p + 0x058)); // 0246691CD888 0x58 M_CurrentQueryPath          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
