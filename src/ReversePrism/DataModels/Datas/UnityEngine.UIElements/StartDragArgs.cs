using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    ModelPrimitiveType string string string String
    // 018 VisualMode                               ModelEnumType DragVisualMode DragVisualMode DragVisualMode Int32
    // 020 GenericData                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 <unityObjectReferences>k__BackingField   IEnumerable`1<Object> IL2CPP_TYPE_GENERICINST
    public partial class StartDragArgs : DataModel
    {
        public string                                   Title                                   { get; set; }
        public DragVisualMode                           VisualMode                              { get; set; }
        public Hashtable?                               GenericData                             { get; set; }

        public static StartDragArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartDragArgs() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Title                       ( ModelPrimitiveType string string string String )
            value.VisualMode                                = (DragVisualMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 VisualMode                  ( ModelEnumType DragVisualMode DragVisualMode DragVisualMode Int32 )
            value.GenericData                               = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 GenericData                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
