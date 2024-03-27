using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186594E70 ModelClassType ILiveEventBonusOverlayView ILiveEventBonusOverlayView ILiveEventBonusOverlayView Pointer
    // 018 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 000 ItemLimitPerRow                          int IL2CPP_TYPE_I4
    // 028 IsShowDetail                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 IdolList                                 000185CF5368 ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer
    // 038 BonusRate                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveEventBonusOverlayPresenter
    {
        public ILiveEventBonusOverlayView?              View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public bool                                     IsShowDetail                            { get; set; }
        public List<IEventBonusProduceIdolStatus>?      IdolList                                { get; set; }
        public int                                      BonusRate                               { get; set; }
        public int                                      EventId                                 { get; set; }

        public static LiveEventBonusOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusOverlayPresenter();

            value.View                                      = GetObject<ILiveEventBonusOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILiveEventBonusOverlayView.FromPointer); // 0270D627E518 0x10 View                        ( 000186594E70 ModelClassType ILiveEventBonusOverlayView ILiveEventBonusOverlayView ILiveEventBonusOverlayView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D627E538 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D627E558 0x20 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.IsShowDetail                              = GetBool(new IntPtr(p + 0x028)); // 0270D627E598 0x28 IsShowDetail                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IdolList                                  = GetObjectList<IEventBonusProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IEventBonusProduceIdolStatus.FromPointer); // 0270D627E5B8 0x30 IdolList                    ( 000185CF5368 ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer )
            value.BonusRate                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D627E5D8 0x38 BonusRate                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x03C)); // 0270D627E5F8 0x3C EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
