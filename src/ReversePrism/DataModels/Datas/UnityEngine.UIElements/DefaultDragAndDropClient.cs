using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GenericData                            ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 M_DraggedInfoLabel                       ModelClassType Label Label Label Pointer
    // 020 M_VisualMode                             ModelEnumType DragVisualMode DragVisualMode DragVisualMode Int32
    // 028 m_UnityObjectReferences                  IEnumerable`1<Object> IL2CPP_TYPE_GENERICINST
    public partial class DefaultDragAndDropClient : DataModel
    {
        public Hashtable?                               M_GenericData                           { get; set; }
        public Label?                                   M_DraggedInfoLabel                      { get; set; }
        public DragVisualMode                           M_VisualMode                            { get; set; }

        public static DefaultDragAndDropClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDragAndDropClient() { Pointer= p0 };

            value.M_GenericData                             = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 M_GenericData               ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.M_DraggedInfoLabel                        = GetObject<Label>(new IntPtr(p + 0x018), ReversePrism.DataModels.Label.FromPointer); // 0x18 M_DraggedInfoLabel          ( ModelClassType Label Label Label Pointer )
            value.M_VisualMode                              = (DragVisualMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_VisualMode                ( ModelEnumType DragVisualMode DragVisualMode DragVisualMode Int32 )

            return value;
        }
    }
}
