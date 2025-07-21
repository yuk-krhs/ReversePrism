using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InGamePCardContent                       ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 028 BeginDragTrigger                         ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer
    // 030 DragTrigger                              ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer
    // 038 UpdateSelectedTrigger                    ModelClassType ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger Pointer
    // 040 EndDragTrigger                           ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer
    // 048 BuffEffect                               ModelClassType Animator Animator Animator Pointer
    // 050 DeBuffEffect                             ModelClassType Animator Animator Animator Pointer
    // 058 AvailableEffect                          ModelClassType Animator Animator Animator Pointer
    // 060 SpecialAvailableChangeEffect             ModelClassType Animator Animator Animator Pointer
    // 068 SpecialAvailableEffect                   ModelClassType Animator Animator Animator Pointer
    // 070 CardAnimator                             ModelClassType Animator Animator Animator Pointer
    // 078 CenterPoint                              ModelClassType Transform Transform Transform Pointer
    // 080 onDrag                                   Subject`1<DragState> IL2CPP_TYPE_GENERICINST
    // 088 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static PlayerUsePCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerUsePCardContent() { Pointer= p0 };

            value.InGamePCardContent                        = GetObject<InGamePCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0x20 InGamePCardContent          ( ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.BeginDragTrigger                          = GetObject<ObservableBeginDragTrigger>(new IntPtr(p + 0x028), ReversePrism.DataModels.ObservableBeginDragTrigger.FromPointer); // 0x28 BeginDragTrigger            ( ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer )
            value.DragTrigger                               = GetObject<ObservableDragTrigger>(new IntPtr(p + 0x030), ReversePrism.DataModels.ObservableDragTrigger.FromPointer); // 0x30 DragTrigger                 ( ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer )
            value.UpdateSelectedTrigger                     = GetObject<ObservableUpdateSelectedTrigger>(new IntPtr(p + 0x038), ReversePrism.DataModels.ObservableUpdateSelectedTrigger.FromPointer); // 0x38 UpdateSelectedTrigger       ( ModelClassType ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger ObservableUpdateSelectedTrigger Pointer )
            value.EndDragTrigger                            = GetObject<ObservableEndDragTrigger>(new IntPtr(p + 0x040), ReversePrism.DataModels.ObservableEndDragTrigger.FromPointer); // 0x40 EndDragTrigger              ( ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer )
            value.BuffEffect                                = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 BuffEffect                  ( ModelClassType Animator Animator Animator Pointer )
            value.DeBuffEffect                              = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0x50 DeBuffEffect                ( ModelClassType Animator Animator Animator Pointer )
            value.AvailableEffect                           = GetObject<Animator>(new IntPtr(p + 0x058), ReversePrism.DataModels.Animator.FromPointer); // 0x58 AvailableEffect             ( ModelClassType Animator Animator Animator Pointer )
            value.SpecialAvailableChangeEffect              = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 0x60 SpecialAvailableChangeEffect ( ModelClassType Animator Animator Animator Pointer )
            value.SpecialAvailableEffect                    = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 0x68 SpecialAvailableEffect      ( ModelClassType Animator Animator Animator Pointer )
            value.CardAnimator                              = GetObject<Animator>(new IntPtr(p + 0x070), ReversePrism.DataModels.Animator.FromPointer); // 0x70 CardAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.CenterPoint                               = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 0x78 CenterPoint                 ( ModelClassType Transform Transform Transform Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x88 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
