using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 020 ContentList                              000185CE08B8 ModelClassListType List`1<IADVLogNodeViewModel> List`1<IADVLogNodeViewModel> List<IADVLogNodeViewModel> Pointer
    // 028 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    public partial class ADVLogOverlayViewModel
    {
        public ScenarioID?                              ScenarioId                              { get; set; }
        public string                                   Title                                   { get; set; }
        public List<IADVLogNodeViewModel>?              ContentList                             { get; set; }
        public string                                   CueSheetName                            { get; set; }

        public static ADVLogOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogOverlayViewModel();

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0270D6919440 0x10 ScenarioId                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0270D6919460 0x18 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.ContentList                               = GetObjectList<IADVLogNodeViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IADVLogNodeViewModel.FromPointer); // 0270D6919480 0x20 ContentList                 ( 000185CE08B8 ModelClassListType List`1<IADVLogNodeViewModel> List`1<IADVLogNodeViewModel> List<IADVLogNodeViewModel> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x028)); // 0270D69194A0 0x28 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
