using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               TMP_UpdateManager IL2CPP_TYPE_CLASS
    // 010 m_LayoutQueueLookup                      HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 018 M_LayoutRebuildQueue                     000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer
    // 020 m_GraphicQueueLookup                     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 028 M_GraphicRebuildQueue                    000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer
    // 030 m_InternalUpdateLookup                   HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 038 M_InternalUpdateQueue                    000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer
    // 040 m_CullingUpdateLookup                    HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 048 M_CullingUpdateQueue                     000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer
    // 008 k_RegisterTextObjectForUpdateMarker      ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_RegisterTextElementForGraphicRebuildMarker 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_RegisterTextElementForCullingUpdateMarker 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UnregisterTextObjectForUpdateMarker    0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_UnregisterTextElementForGraphicRebuildMarker 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class TMP_UpdateManager : DataModel
    {
        public List<TMP_Text>?                          M_LayoutRebuildQueue                    { get; set; }
        public List<TMP_Text>?                          M_GraphicRebuildQueue                   { get; set; }
        public List<TMP_Text>?                          M_InternalUpdateQueue                   { get; set; }
        public List<TMP_Text>?                          M_CullingUpdateQueue                    { get; set; }
        public ProfilerMarker                           K_RegisterTextElementForGraphicRebuildMarker { get; set; }
        public ProfilerMarker                           K_RegisterTextElementForCullingUpdateMarker { get; set; }
        public ProfilerMarker                           K_UnregisterTextObjectForUpdateMarker   { get; set; }
        public ProfilerMarker                           K_UnregisterTextElementForGraphicRebuildMarker { get; set; }

        public static TMP_UpdateManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_UpdateManager() { Pointer= p0 };

            value.M_LayoutRebuildQueue                      = GetObjectList<TMP_Text>(new IntPtr(p + 0x018), ReversePrism.DataModels.TMP_Text.FromPointer); // 0245A399F550 0x18 M_LayoutRebuildQueue        ( 000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer )
            value.M_GraphicRebuildQueue                     = GetObjectList<TMP_Text>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_Text.FromPointer); // 0245A399F590 0x28 M_GraphicRebuildQueue       ( 000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer )
            value.M_InternalUpdateQueue                     = GetObjectList<TMP_Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.TMP_Text.FromPointer); // 0245A399F5D0 0x38 M_InternalUpdateQueue       ( 000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer )
            value.M_CullingUpdateQueue                      = GetObjectList<TMP_Text>(new IntPtr(p + 0x048), ReversePrism.DataModels.TMP_Text.FromPointer); // 0245A399F610 0x48 M_CullingUpdateQueue        ( 000185D13138 ModelClassListType List`1<TMP_Text> List`1<TMP_Text> List<TMP_Text> Pointer )
            value.K_RegisterTextElementForGraphicRebuildMarker = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0245A399F650 0x10 K_RegisterTextElementForGraphicRebuildMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_RegisterTextElementForCullingUpdateMarker = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0245A399F670 0x18 K_RegisterTextElementForCullingUpdateMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UnregisterTextObjectForUpdateMarker     = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0245A399F690 0x20 K_UnregisterTextObjectForUpdateMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UnregisterTextElementForGraphicRebuildMarker = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0245A399F6B0 0x28 K_UnregisterTextElementForGraphicRebuildMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
