using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer
    // 028 FilterAndSortView                        ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 BtnSwitchSortDirection                   ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 onSelectIndex                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onFilterSort                             Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 onSortDirection                          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 OnClickDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 OnLongPressDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class SupportCharaListView : DataModel
    {
        public EnhancedCharacterSelectGridView?         GridView                                { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                BtnSwitchSortDirection                  { get; set; }
        public IDisposable?                             OnClickDisposable                       { get; set; }
        public IDisposable?                             OnLongPressDisposable                   { get; set; }

        public static SupportCharaListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaListView() { Pointer= p0 };

            value.GridView                                  = GetObject<EnhancedCharacterSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedCharacterSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 FilterAndSortView           ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.BtnSwitchSortDirection                    = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 BtnSwitchSortDirection      ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 OnClickDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnLongPressDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 OnLongPressDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
