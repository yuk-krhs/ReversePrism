using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 BadgeView                                ModelClassType BadgeView BadgeView BadgeView Pointer
    // 030 EventIconView                            ModelClassType EventIconView EventIconView EventIconView Pointer
    // 038 ProduceResumeObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 040 ProduceResumeHideObject                  ModelClassType GameObject GameObject GameObject Pointer
    public partial class CommonFooterButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public BadgeView?                               BadgeView                               { get; set; }
        public EventIconView?                           EventIconView                           { get; set; }
        public GameObject?                              ProduceResumeObject                     { get; set; }
        public GameObject?                              ProduceResumeHideObject                 { get; set; }

        public static CommonFooterButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonFooterButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BadgeView                                 = GetObject<BadgeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeView.FromPointer); // 0x28 BadgeView                   ( ModelClassType BadgeView BadgeView BadgeView Pointer )
            value.EventIconView                             = GetObject<EventIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventIconView.FromPointer); // 0x30 EventIconView               ( ModelClassType EventIconView EventIconView EventIconView Pointer )
            value.ProduceResumeObject                       = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ProduceResumeObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceResumeHideObject                   = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ProduceResumeHideObject     ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
