using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_State                                  ModelEnumType State State State Int32
    // 028 M_CurrentChangeElement                   ModelClassType VisualElement VisualElement VisualElement Pointer
    // 030 M_CurrentChangeParent                    ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class BaseVisualTreeHierarchyTrackerUpdater : DataModel
    {
        public State                                    M_State                                 { get; set; }
        public VisualElement?                           M_CurrentChangeElement                  { get; set; }
        public VisualElement?                           M_CurrentChangeParent                   { get; set; }

        public static BaseVisualTreeHierarchyTrackerUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseVisualTreeHierarchyTrackerUpdater() { Pointer= p0 };

            value.M_State                                   = (State)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_State                     ( ModelEnumType State State State Int32 )
            value.M_CurrentChangeElement                    = GetObject<VisualElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.VisualElement.FromPointer); // 0x28 M_CurrentChangeElement      ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_CurrentChangeParent                     = GetObject<VisualElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElement.FromPointer); // 0x30 M_CurrentChangeParent       ( ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
