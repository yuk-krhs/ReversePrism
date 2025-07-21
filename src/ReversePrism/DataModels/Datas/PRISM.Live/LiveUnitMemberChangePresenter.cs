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
    // 088 View                                     ModelClassType LiveUnitMemberChangeView LiveUnitMemberChangeView LiveUnitMemberChangeView Pointer
    // 090 IdolGridView                             ModelClassType LiveIdolGridView LiveIdolGridView LiveIdolGridView Pointer
    // 098 FilterAndSortView                        ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 0A0 SortDirectionSwitch                      ModelClassType UISwitch UISwitch UISwitch Pointer
    // 0A8 SortFilterAppliedIdols                   ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 0B0 IconDescriptors                          ModelEnumListType LiveIdolIconDescriptor[] LiveIdolIconDescriptor[] List<LiveIdolIconDescriptor> Pointer
    // 0B8 JumpParameter                            ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveUnitMemberChangePresenter : DataModel
    {
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public LiveIdolChangePreview?                   IdolChangePreview                       { get; set; }
        public LiveUnitMemberChangeView?                View                                    { get; set; }
        public LiveIdolGridView?                        IdolGridView                            { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                SortDirectionSwitch                     { get; set; }
        public List<LiveIdol>?                          SortFilterAppliedIdols                  { get; set; }
        public List<LiveIdolIconDescriptor>?            IconDescriptors                         { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }

        public static LiveUnitMemberChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberChangePresenter() { Pointer= p0 };

            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x78 MusicBasicInfoView          ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.IdolChangePreview                         = GetObject<LiveIdolChangePreview>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveIdolChangePreview.FromPointer); // 0x80 IdolChangePreview           ( ModelClassType LiveIdolChangePreview LiveIdolChangePreview LiveIdolChangePreview Pointer )
            value.View                                      = GetObject<LiveUnitMemberChangeView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveUnitMemberChangeView.FromPointer); // 0x88 View                        ( ModelClassType LiveUnitMemberChangeView LiveUnitMemberChangeView LiveUnitMemberChangeView Pointer )
            value.IdolGridView                              = GetObject<LiveIdolGridView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveIdolGridView.FromPointer); // 0x90 IdolGridView                ( ModelClassType LiveIdolGridView LiveIdolGridView LiveIdolGridView Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x098), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x98 FilterAndSortView           ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortDirectionSwitch                       = GetObject<UISwitch>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UISwitch.FromPointer); // 0xA0 SortDirectionSwitch         ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.SortFilterAppliedIdols                    = GetObjectList<LiveIdol>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.LiveIdol.FromPointer); // 0xA8 SortFilterAppliedIdols      ( ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.IconDescriptors                           = GetEnumList<LiveIdolIconDescriptor>(new IntPtr(p + 0x0B0)); // 0xB0 IconDescriptors             ( ModelEnumListType LiveIdolIconDescriptor[] LiveIdolIconDescriptor[] List<LiveIdolIconDescriptor> Pointer )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.JumpParameter.FromPointer); // 0xB8 JumpParameter               ( ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
