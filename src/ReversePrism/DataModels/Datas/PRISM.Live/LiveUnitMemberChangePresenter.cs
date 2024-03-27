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
    // 090 View                                     0001865964F0 ModelClassType LiveUnitMemberChangeView LiveUnitMemberChangeView LiveUnitMemberChangeView Pointer
    // 098 IdolGridView                             000186557310 ModelClassType LiveIdolGridView LiveIdolGridView LiveIdolGridView Pointer
    // 0A0 FilterAndSortView                        000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 0A8 SortDirectionSwitch                      0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 0B0 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0B8 FIdolDetailPopupCaller                   000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer
    // 0C0 SortFilterAppliedIdols                   000185B90840 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 0C8 IconDescriptors                          000185B90C20 ModelEnumListType LiveIdolIconDescriptor[] LiveIdolIconDescriptor[] List<LiveIdolIconDescriptor> Pointer
    // 0D0 JumpParameter                            0001866DD880 ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveUnitMemberChangePresenter
    {
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public LiveIdolChangePreview?                   IdolChangePreview                       { get; set; }
        public LiveUnitMemberChangeView?                View                                    { get; set; }
        public LiveIdolGridView?                        IdolGridView                            { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                SortDirectionSwitch                     { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public FIdolDetailPopupCaller?                  FIdolDetailPopupCaller                  { get; set; }
        public List<LiveIdol>?                          SortFilterAppliedIdols                  { get; set; }
        public List<LiveIdolIconDescriptor>?            IconDescriptors                         { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }

        public static LiveUnitMemberChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberChangePresenter();

            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x080), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270D52B3D30 0x80 MusicBasicInfoView          ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.IdolChangePreview                         = GetObject<LiveIdolChangePreview>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveIdolChangePreview.FromPointer); // 0270D52B3D50 0x88 IdolChangePreview           ( 0001865568C0 ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer )
            value.View                                      = GetObject<LiveUnitMemberChangeView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveUnitMemberChangeView.FromPointer); // 0270D52B3D70 0x90 View                        ( 0001865964F0 ModelClassType LiveUnitMemberChangeView LiveUnitMemberChangeView LiveUnitMemberChangeView Pointer )
            value.IdolGridView                              = GetObject<LiveIdolGridView>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveIdolGridView.FromPointer); // 0270D52B3D90 0x98 IdolGridView                ( 000186557310 ModelClassType LiveIdolGridView LiveIdolGridView LiveIdolGridView Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270D52B3DB0 0xA0 FilterAndSortView           ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortDirectionSwitch                       = GetObject<UISwitch>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UISwitch.FromPointer); // 0270D52B3DD0 0xA8 SortDirectionSwitch         ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D52B3DF0 0xB0 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.FIdolDetailPopupCaller                    = GetObject<FIdolDetailPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.FIdolDetailPopupCaller.FromPointer); // 0270D52B3E10 0xB8 FIdolDetailPopupCaller      ( 000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer )
            value.SortFilterAppliedIdols                    = GetObjectList<LiveIdol>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveIdol.FromPointer); // 0270D52B3E30 0xC0 SortFilterAppliedIdols      ( 000185B90840 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.IconDescriptors                           = GetEnumList<LiveIdolIconDescriptor>(new IntPtr(p + 0x0C8)); // 0270D52B3E50 0xC8 IconDescriptors             ( 000185B90C20 ModelEnumListType LiveIdolIconDescriptor[] LiveIdolIconDescriptor[] List<LiveIdolIconDescriptor> Pointer )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.JumpParameter.FromPointer); // 0270D52B3E70 0xD0 JumpParameter               ( 0001866DD880 ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
