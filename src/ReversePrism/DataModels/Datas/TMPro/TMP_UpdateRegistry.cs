using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               TMP_UpdateRegistry IL2CPP_TYPE_CLASS
    // 010 M_LayoutRebuildQueue                     000185CE1518 ModelClassListType List`1<ICanvasElement> List`1<ICanvasElement> List<ICanvasElement> Pointer
    // 018 m_LayoutQueueLookup                      HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 020 M_GraphicRebuildQueue                    000185CE1518 ModelClassListType List`1<ICanvasElement> List`1<ICanvasElement> List<ICanvasElement> Pointer
    // 028 m_GraphicQueueLookup                     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TMP_UpdateRegistry
    {
        public List<ICanvasElement>?                    M_LayoutRebuildQueue                    { get; set; }
        public List<ICanvasElement>?                    M_GraphicRebuildQueue                   { get; set; }

        public static TMP_UpdateRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_UpdateRegistry();

            value.M_LayoutRebuildQueue                      = GetObjectList<ICanvasElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICanvasElement.FromPointer); // 0270DA657428 0x10 M_LayoutRebuildQueue        ( 000185CE1518 ModelClassListType List`1<ICanvasElement> List`1<ICanvasElement> List<ICanvasElement> Pointer )
            value.M_GraphicRebuildQueue                     = GetObjectList<ICanvasElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICanvasElement.FromPointer); // 0270DA657468 0x20 M_GraphicRebuildQueue       ( 000185CE1518 ModelClassListType List`1<ICanvasElement> List`1<ICanvasElement> List<ICanvasElement> Pointer )

            return value;
        }
    }
}
