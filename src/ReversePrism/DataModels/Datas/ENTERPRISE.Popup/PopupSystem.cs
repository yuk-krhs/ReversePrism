using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NextDialogID                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 PopupLists                               000185D281B8 ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer
    // 030 InitLists                                000185D281B8 ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer
    // 038 DisposablesHiddenFlame                   0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 IsHiddenFlame                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 <PopupCount>k__BackingField              ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PopupSystem
    {
        public int                                      NextDialogID                            { get; set; }
        public List<PopupInfo>?                         PopupLists                              { get; set; }
        public List<PopupInfo>?                         InitLists                               { get; set; }
        public CompositeDisposable?                     DisposablesHiddenFlame                  { get; set; }
        public bool                                     IsHiddenFlame                           { get; set; }

        public static PopupSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupSystem();

            value.NextDialogID                              = GetInt32(new IntPtr(p + 0x020)); // 0270D0A52118 0x20 NextDialogID                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PopupLists                                = GetObjectList<PopupInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupInfo.FromPointer); // 0270D0A52138 0x28 PopupLists                  ( 000185D281B8 ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer )
            value.InitLists                                 = GetObjectList<PopupInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupInfo.FromPointer); // 0270D0A52158 0x30 InitLists                   ( 000185D281B8 ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer )
            value.DisposablesHiddenFlame                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D0A52178 0x38 DisposablesHiddenFlame      ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsHiddenFlame                             = GetBool(new IntPtr(p + 0x040)); // 0270D0A52198 0x40 IsHiddenFlame               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
