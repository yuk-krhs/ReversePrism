using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 MusicBasicInfoView                       ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 080 IdolChangePreview                        ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer
    // 088 View                                     ModelClassType LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView Pointer
    // 090 IdolListView                             ModelClassType LiveMVIdolListView LiveMVIdolListView LiveMVIdolListView Pointer
    // 098 JumpParameter                            ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveMVUnitMemberChangePresenter : DataModel
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
            var value   = new LiveMVUnitMemberChangePresenter() { Pointer= p0 };

            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x78 MusicBasicInfoView          ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.IdolChangePreview                         = GetObject<LiveIdolChangePreview>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveIdolChangePreview.FromPointer); // 0x80 IdolChangePreview           ( ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer )
            value.View                                      = GetObject<LiveMVUnitMemberChangeView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveMVUnitMemberChangeView.FromPointer); // 0x88 View                        ( ModelClassType LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView LiveMVUnitMemberChangeView Pointer )
            value.IdolListView                              = GetObject<LiveMVIdolListView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMVIdolListView.FromPointer); // 0x90 IdolListView                ( ModelClassType LiveMVIdolListView LiveMVIdolListView LiveMVIdolListView Pointer )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x098), ReversePrism.DataModels.JumpParameter.FromPointer); // 0x98 JumpParameter               ( ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
