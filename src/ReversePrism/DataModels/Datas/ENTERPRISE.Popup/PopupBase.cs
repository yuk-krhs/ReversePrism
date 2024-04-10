using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Status                                   000186765860 ModelEnumType PopupStatus PopupStatus PopupStatus Int32
    // 024 Attribute                                00018675F040 ModelEnumType PopupAttribute PopupAttribute PopupAttribute Int32
    // 028 DialogID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C IsAutoDelete                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D IsCancelPopup                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 <OnHiddenCallback>k__BackingField        Func`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 038 <DisappearCheck>k__BackingField          Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 <OnDestroyCallback>k__BackingField       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 048 SelectID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 WindowObject                             0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ContentObject                            0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 060 BackgroundObject                         0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 068 Content                                  000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 070 BackgroundImage                          0001866CD000 ModelClassType Image Image Image Pointer
    // 078 terminateTask                            UniTaskCompletionSource`1<int> IL2CPP_TYPE_GENERICINST
    // 080 WindowCanvasGroup                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PopupBase : DataModel
    {
        public PopupStatus                              Status                                  { get; set; }
        public PopupAttribute                           Attribute                               { get; set; }
        public int                                      DialogID                                { get; set; }
        public bool                                     IsAutoDelete                            { get; set; }
        public bool                                     IsCancelPopup                           { get; set; }
        public int                                      SelectID                                { get; set; }
        public GameObject?                              WindowObject                            { get; set; }
        public GameObject?                              ContentObject                           { get; set; }
        public GameObject?                              BackgroundObject                        { get; set; }
        public PopupContentBase?                        Content                                 { get; set; }
        public Image?                                   BackgroundImage                         { get; set; }
        public CanvasGroup?                             WindowCanvasGroup                       { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static PopupBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupBase() { Pointer= p0 };

            value.Status                                    = (PopupStatus)GetInt32(new IntPtr(p + 0x020)); // 0245A403A828 0x20 Status                      ( 000186765860 ModelEnumType PopupStatus PopupStatus PopupStatus Int32 )
            value.Attribute                                 = (PopupAttribute)GetInt32(new IntPtr(p + 0x024)); // 0245A403A848 0x24 Attribute                   ( 00018675F040 ModelEnumType PopupAttribute PopupAttribute PopupAttribute Int32 )
            value.DialogID                                  = GetInt32(new IntPtr(p + 0x028)); // 0245A403A868 0x28 DialogID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsAutoDelete                              = GetBool(new IntPtr(p + 0x02C)); // 0245A403A888 0x2C IsAutoDelete                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsCancelPopup                             = GetBool(new IntPtr(p + 0x02D)); // 0245A403A8A8 0x2D IsCancelPopup               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectID                                  = GetInt32(new IntPtr(p + 0x048)); // 0245A403A928 0x48 SelectID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WindowObject                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0245A403A948 0x50 WindowObject                ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentObject                             = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0245A403A968 0x58 ContentObject               ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.BackgroundObject                          = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0245A403A988 0x60 BackgroundObject            ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Content                                   = GetObject<PopupContentBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0245A403A9A8 0x68 Content                     ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0245A403A9C8 0x70 BackgroundImage             ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.WindowCanvasGroup                         = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A403AA08 0x80 WindowCanvasGroup           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A403AA28 0x88 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
