using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkillView                                ModelClassType LiveSkillView LiveSkillView LiveSkillView Pointer
    // 028 Margin                                   ModelPrimitiveType float float float Single
    // 030 SkillViews                               ModelClassListType List`1<LiveSkillView> List`1<LiveSkillView> List<LiveSkillView> Pointer
    // 038 activeSkillViews                         Queue`1<LiveSkillView> IL2CPP_TYPE_GENERICINST
    // 040 idolTextureDic                           Dictionary`2<LiveIdol, Texture2D> IL2CPP_TYPE_GENERICINST
    public partial class LiveSkillNotificationView : DataModel
    {
        public LiveSkillView?                           SkillView                               { get; set; }
        public float                                    Margin                                  { get; set; }
        public List<LiveSkillView>?                     SkillViews                              { get; set; }

        public static LiveSkillNotificationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillNotificationView() { Pointer= p0 };

            value.SkillView                                 = GetObject<LiveSkillView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveSkillView.FromPointer); // 0x20 SkillView                   ( ModelClassType LiveSkillView LiveSkillView LiveSkillView Pointer )
            value.Margin                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 Margin                      ( ModelPrimitiveType float float float Single )
            value.SkillViews                                = GetObjectList<LiveSkillView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSkillView.FromPointer); // 0x30 SkillViews                  ( ModelClassListType List`1<LiveSkillView> List`1<LiveSkillView> List<LiveSkillView> Pointer )

            return value;
        }
    }
}
