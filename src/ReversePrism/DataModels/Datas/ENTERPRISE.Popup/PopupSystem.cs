using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NextDialogID                             ModelPrimitiveType int int int Int32
    // 028 PopupLists                               ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer
    // 030 InitLists                                ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer
    // 038 DisposablesHiddenFlame                   ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 IsHiddenFlame                            ModelPrimitiveType bool bool bool Bool
    // 048 <PopupCount>k__BackingField              ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PopupSystem : DataModel
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
            var value   = new PopupSystem() { Pointer= p0 };

            value.NextDialogID                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 NextDialogID                ( ModelPrimitiveType int int int Int32 )
            value.PopupLists                                = GetObjectList<PopupInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupInfo.FromPointer); // 0x28 PopupLists                  ( ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer )
            value.InitLists                                 = GetObjectList<PopupInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupInfo.FromPointer); // 0x30 InitLists                   ( ModelClassListType List`1<PopupInfo> List`1<PopupInfo> List<PopupInfo> Pointer )
            value.DisposablesHiddenFlame                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 DisposablesHiddenFlame      ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsHiddenFlame                             = GetBool(new IntPtr(p + 0x040)); // 0x40 IsHiddenFlame               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
