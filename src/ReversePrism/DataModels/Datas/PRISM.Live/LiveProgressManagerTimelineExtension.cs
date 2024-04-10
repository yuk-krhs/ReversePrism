using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimelineController                       00018666EEE0 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 018 OffsetTime                               000186666F40 ModelPrimitiveType float float float Single
    // 01C SoundTimeOffset                          0001866656B0 ModelPrimitiveType float float float Single
    // 020 InitializeTask                           0001866A01C0 ModelEnumType UniTask UniTask UniTask Int32
    public partial class LiveProgressManagerTimelineExtension : DataModel
    {
        public TimelineController?                      TimelineController                      { get; set; }
        public float                                    OffsetTime                              { get; set; }
        public float                                    SoundTimeOffset                         { get; set; }
        public UniTask                                  InitializeTask                          { get; set; }

        public static LiveProgressManagerTimelineExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveProgressManagerTimelineExtension() { Pointer= p0 };

            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x010), ReversePrism.DataModels.TimelineController.FromPointer); // 024664EA6EC0 0x10 TimelineController          ( 00018666EEE0 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.OffsetTime                                = GetSingle(new IntPtr(p + 0x018)); // 024664EA6EE0 0x18 OffsetTime                  ( 000186666F40 ModelPrimitiveType float float float Single )
            value.SoundTimeOffset                           = GetSingle(new IntPtr(p + 0x01C)); // 024664EA6F00 0x1C SoundTimeOffset             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InitializeTask                            = (UniTask)GetInt32(new IntPtr(p + 0x020)); // 024664EA6F20 0x20 InitializeTask              ( 0001866A01C0 ModelEnumType UniTask UniTask UniTask Int32 )

            return value;
        }
    }
}
