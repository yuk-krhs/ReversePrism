using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Activatable                            ModelClassType IVisualElementPanelActivatable IVisualElementPanelActivatable IVisualElementPanelActivatable Pointer
    // 018 IsActive                                 ModelPrimitiveType bool bool bool Bool
    // 019 IsDetaching                              ModelPrimitiveType bool bool bool Bool
    // 020 m_OnAttachToPanelCallback                EventCallback`1<AttachToPanelEvent> IL2CPP_TYPE_GENERICINST
    // 028 m_OnDetachFromPanelCallback              EventCallback`1<DetachFromPanelEvent> IL2CPP_TYPE_GENERICINST
    public partial class VisualElementPanelActivator : DataModel
    {
        public IVisualElementPanelActivatable?          M_Activatable                           { get; set; }
        public bool                                     IsActive                                { get; set; }
        public bool                                     IsDetaching                             { get; set; }

        public static VisualElementPanelActivator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementPanelActivator() { Pointer= p0 };

            value.M_Activatable                             = GetObject<IVisualElementPanelActivatable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IVisualElementPanelActivatable.FromPointer); // 0x10 M_Activatable               ( ModelClassType IVisualElementPanelActivatable IVisualElementPanelActivatable IVisualElementPanelActivatable Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsActive                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsDetaching                               = GetBool(new IntPtr(p + 0x019)); // 0x19 IsDetaching                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
