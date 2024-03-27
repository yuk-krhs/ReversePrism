using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 MusicBasicInfoView                       0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 088 IdolChangePreview                        0001865568C0 ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer
    // 090 View                                     000186562060 ModelClassType LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView Pointer
    // 098 IdolListView                             00018655AEA0 ModelClassType LiveMVIdolListView LiveMVIdolListView LiveMVIdolListView Pointer
    // 0A0 JumpParameter                            0001866AFD00 ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveMVUnitMemberChangePresenter
    {
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public LiveIdolChangePreview?                   IdolChangePreview                       { get; set; }
        public LiveMVUnitMemberChangeView?              View                                    { get; set; }
        public LiveMVIdolListView?                      IdolListView                            { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }

        public static LiveMVUnitMemberChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitMemberChangePresenter();

            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x080), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270D51B85F8 0x80 MusicBasicInfoView          ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.IdolChangePreview                         = GetObject<LiveIdolChangePreview>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveIdolChangePreview.FromPointer); // 0270D51B8618 0x88 IdolChangePreview           ( 0001865568C0 ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer )
            value.View                                      = GetObject<LiveMVUnitMemberChangeView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMVUnitMemberChangeView.FromPointer); // 0270D51B8638 0x90 View                        ( 000186562060 ModelClassType LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView Pointer )
            value.IdolListView                              = GetObject<LiveMVIdolListView>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveMVIdolListView.FromPointer); // 0270D51B8658 0x98 IdolListView                ( 00018655AEA0 ModelClassType LiveMVIdolListView LiveMVIdolListView LiveMVIdolListView Pointer )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.JumpParameter.FromPointer); // 0270D51B8678 0xA0 JumpParameter               ( 0001866AFD00 ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
