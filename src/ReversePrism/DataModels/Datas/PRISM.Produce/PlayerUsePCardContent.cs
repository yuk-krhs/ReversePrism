using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InGamePCardContent                       0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 028 BeginDragTrigger                         0001866CE5C0 ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer
    // 030 DragTrigger                              0001866D04C0 ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer
    // 038 UpdateSelectedTrigger                    0001866D5720 ModelClassType ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger Pointer
    // 040 EndDragTrigger                           0001866D0E60 ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer
    // 048 BuffEffect                               0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 050 DeBuffEffect                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 058 AvailableEffect                          0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 060 SpecialAvailableChangeEffect             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 068 SpecialAvailableEffect                   0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 070 CardAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 078 CenterPoint                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 080 onDrag                                   Subject`1<DragState> IL2CPP_TYPE_GENERICINST
    public partial class PlayerUsePCardContent : DataModel
    {
        public InGamePCardContent?                      InGamePCardContent                      { get; set; }
        public ObservableBeginDragTrigger?              BeginDragTrigger                        { get; set; }
        public ObservableDragTrigger?                   DragTrigger                             { get; set; }
        public ObservableUpdateSelectedTrigger?         UpdateSelectedTrigger                   { get; set; }
        public ObservableEndDragTrigger?                EndDragTrigger                          { get; set; }
        public Animator?                                BuffEffect                              { get; set; }
        public Animator?                                DeBuffEffect                            { get; set; }
        public Animator?                                AvailableEffect                         { get; set; }
        public Animator?                                SpecialAvailableChangeEffect            { get; set; }
        public Animator?                                SpecialAvailableEffect                  { get; set; }
        public Animator?                                CardAnimator                            { get; set; }
        public Transform?                               CenterPoint                             { get; set; }

        public static PlayerUsePCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerUsePCardContent() { Pointer= p0 };

            value.InGamePCardContent                        = GetObject<InGamePCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 024665B698E8 0x20 InGamePCardContent          ( 0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.BeginDragTrigger                          = GetObject<ObservableBeginDragTrigger>(new IntPtr(p + 0x028), ReversePrism.DataModels.ObservableBeginDragTrigger.FromPointer); // 024665B69908 0x28 BeginDragTrigger            ( 0001866CE5C0 ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer )
            value.DragTrigger                               = GetObject<ObservableDragTrigger>(new IntPtr(p + 0x030), ReversePrism.DataModels.ObservableDragTrigger.FromPointer); // 024665B69928 0x30 DragTrigger                 ( 0001866D04C0 ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer )
            value.UpdateSelectedTrigger                     = GetObject<ObservableUpdateSelectedTrigger>(new IntPtr(p + 0x038), ReversePrism.DataModels.ObservableUpdateSelectedTrigger.FromPointer); // 024665B69948 0x38 UpdateSelectedTrigger       ( 0001866D5720 ModelClassType ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger Pointer )
            value.EndDragTrigger                            = GetObject<ObservableEndDragTrigger>(new IntPtr(p + 0x040), ReversePrism.DataModels.ObservableEndDragTrigger.FromPointer); // 024665B69968 0x40 EndDragTrigger              ( 0001866D0E60 ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer )
            value.BuffEffect                                = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 024665B69988 0x48 BuffEffect                  ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.DeBuffEffect                              = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 024665B699A8 0x50 DeBuffEffect                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.AvailableEffect                           = GetObject<Animator>(new IntPtr(p + 0x058), ReversePrism.DataModels.Animator.FromPointer); // 024665B699C8 0x58 AvailableEffect             ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SpecialAvailableChangeEffect              = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 024665B699E8 0x60 SpecialAvailableChangeEffect ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SpecialAvailableEffect                    = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 024665B69A08 0x68 SpecialAvailableEffect      ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CardAnimator                              = GetObject<Animator>(new IntPtr(p + 0x070), ReversePrism.DataModels.Animator.FromPointer); // 024665B69A28 0x70 CardAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CenterPoint                               = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 024665B69A48 0x78 CenterPoint                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
