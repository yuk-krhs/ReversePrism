using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 WindowCanvasGroup                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ViewStatus                               0001866E0F50 ModelEnumType ViewStatusType ViewStatusType ViewStatusType Int32
    // 030 ViewType                                 000186692850 ModelClassType Type Type Type Pointer
    // 038 JumpParam                                000186696190 ModelClassType IViewParameter IViewParameter IViewParameter Pointer
    // 040 PopupAssets                              000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 PopupNames                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    public partial class ViewBase
    {
        public CanvasGroup?                             WindowCanvasGroup                       { get; set; }
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
            var value   = new ViewBase();

            value.WindowCanvasGroup                         = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270024F74A8 0x20 WindowCanvasGroup           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewStatus                                = (ViewStatusType)GetInt32(new IntPtr(p + 0x028)); // 0270024F74C8 0x28 ViewStatus                  ( 0001866E0F50 ModelEnumType ViewStatusType ViewStatusType ViewStatusType Int32 )
            value.ViewType                                  = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0270024F74E8 0x30 ViewType                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.JumpParam                                 = GetObject<IViewParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.IViewParameter.FromPointer); // 0270024F7508 0x38 JumpParam                   ( 000186696190 ModelClassType IViewParameter IViewParameter IViewParameter Pointer )
            value.PopupAssets                               = GetStringList(new IntPtr(p + 0x040)); // 0270024F7528 0x40 PopupAssets                 ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PopupNames                                = GetStringList(new IntPtr(p + 0x048)); // 0270024F7548 0x48 PopupNames                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
