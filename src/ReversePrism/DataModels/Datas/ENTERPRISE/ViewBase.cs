using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewStatus                               ModelEnumType ViewStatusType ViewStatusType ViewStatusType Int32
    // 028 ViewType                                 ModelClassType Type Type Type Pointer
    // 030 JumpParam                                ModelClassType IViewParameter IViewParameter IViewParameter Pointer
    // 038 PopupAssets                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 PopupNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    public partial class ViewBase : DataModel
    {
        public ViewStatusType                           ViewStatus                              { get; set; }
        public Type?                                    ViewType                                { get; set; }
        public IViewParameter?                          JumpParam                               { get; set; }
        public List<string>?                            PopupAssets                             { get; set; }
        public List<string>?                            PopupNames                              { get; set; }

        public static ViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewBase() { Pointer= p0 };

            value.ViewStatus                                = (ViewStatusType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ViewStatus                  ( ModelEnumType ViewStatusType ViewStatusType ViewStatusType Int32 )
            value.ViewType                                  = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 ViewType                    ( ModelClassType Type Type Type Pointer )
            value.JumpParam                                 = GetObject<IViewParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IViewParameter.FromPointer); // 0x30 JumpParam                   ( ModelClassType IViewParameter IViewParameter IViewParameter Pointer )
            value.PopupAssets                               = GetStringList(new IntPtr(p + 0x038)); // 0x38 PopupAssets                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PopupNames                                = GetStringList(new IntPtr(p + 0x040)); // 0x40 PopupNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
