using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkillView                                00018657F540 ModelClassType LiveSkillView LiveSkillView LiveSkillView Pointer
    // 028 Margin                                   0001866656B0 ModelPrimitiveType float float float Single
    // 030 SkillViews                               000185CF0958 ModelClassListType List`1<LiveSkillView> List`1<LiveSkillView> List<LiveSkillView> Pointer
    // 038 activeSkillViews                         Queue`1<LiveSkillView> IL2CPP_TYPE_GENERICINST
    // 040 idolTextureDic                           Dictionary`2<string, Texture2D> IL2CPP_TYPE_GENERICINST
    public partial class LiveSkillNotificationView
    {
        public LiveSkillView?                           SkillView                               { get; set; }
        public float                                    Margin                                  { get; set; }
        public List<LiveSkillView>?                     SkillViews                              { get; set; }

        public static LiveSkillNotificationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillNotificationView();

            value.SkillView                                 = GetObject<LiveSkillView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveSkillView.FromPointer); // 0270D5049B80 0x20 SkillView                   ( 00018657F540 ModelClassType LiveSkillView LiveSkillView LiveSkillView Pointer )
            value.Margin                                    = GetSingle(new IntPtr(p + 0x028)); // 0270D5049BA0 0x28 Margin                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SkillViews                                = GetObjectList<LiveSkillView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSkillView.FromPointer); // 0270D5049BC0 0x30 SkillViews                  ( 000185CF0958 ModelClassListType List`1<LiveSkillView> List`1<LiveSkillView> List<LiveSkillView> Pointer )

            return value;
        }
    }
}
