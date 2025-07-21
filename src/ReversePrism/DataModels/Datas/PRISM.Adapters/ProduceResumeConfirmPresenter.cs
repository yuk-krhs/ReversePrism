using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ProduceResumeModel ProduceResumeModel ProduceResumeModel Pointer
    // 018 ProduceResumeConfirmPopupSource          ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 020 CancelAction                             ModelClassType Action Action Action Pointer
    // 028 FinishAction                             ModelClassType Action Action Action Pointer
    // 030 ResumeAction                             ModelClassType Action Action Action Pointer
    // 038 Popup                                    ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    // 040 JumpParam                                ModelPrimitiveType int int int Int32
    public partial class ProduceResumeConfirmPresenter : DataModel
    {
        public ProduceResumeModel?                      Model                                   { get; set; }
        public PopupContentBase?                        ProduceResumeConfirmPopupSource         { get; set; }
        public Action?                                  CancelAction                            { get; set; }
        public Action?                                  FinishAction                            { get; set; }
        public Action?                                  ResumeAction                            { get; set; }
        public CommonPopupWindow?                       Popup                                   { get; set; }
        public int                                      JumpParam                               { get; set; }

        public static ProduceResumeConfirmPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeConfirmPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ProduceResumeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResumeModel.FromPointer); // 0x10 Model                       ( ModelClassType ProduceResumeModel ProduceResumeModel ProduceResumeModel Pointer )
            value.ProduceResumeConfirmPopupSource           = GetObject<PopupContentBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x18 ProduceResumeConfirmPopupSource ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.CancelAction                              = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 CancelAction                ( ModelClassType Action Action Action Pointer )
            value.FinishAction                              = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0x28 FinishAction                ( ModelClassType Action Action Action Pointer )
            value.ResumeAction                              = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 ResumeAction                ( ModelClassType Action Action Action Pointer )
            value.Popup                                     = GetObject<CommonPopupWindow>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 0x38 Popup                       ( ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.JumpParam                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 JumpParam                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
