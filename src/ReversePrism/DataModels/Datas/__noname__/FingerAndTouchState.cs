using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateMask                               000186705EF0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 018 Fingers                                  000185B7F830 ModelClassListType Finger[] Finger[] List<Finger> Pointer
    // 020 ActiveFingers                            000185B7F830 ModelClassListType Finger[] Finger[] List<Finger> Pointer
    // 028 ActiveTouches                            000185CAC3F8 ModelEnumListType Touch[] Touch[] List<Touch> Pointer
    // 030 ActiveFingerCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 ActiveTouchCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 TotalFingerCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C LastId                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 040 HaveBuiltActiveTouches                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 041 HaveActiveTouchesNeedingRefreshNextUpdate 000186595960 ModelPrimitiveType bool bool bool Bool
    // 048 activeTouchState                         InputStateHistory`1<TouchState> IL2CPP_TYPE_GENERICINST
    public partial class FingerAndTouchState
    {
        public InputUpdateType                          UpdateMask                              { get; set; }
        public List<Finger>?                            Fingers                                 { get; set; }
        public List<Finger>?                            ActiveFingers                           { get; set; }
        public List<Touch>?                             ActiveTouches                           { get; set; }
        public int                                      ActiveFingerCount                       { get; set; }
        public int                                      ActiveTouchCount                        { get; set; }
        public int                                      TotalFingerCount                        { get; set; }
        public uint                                     LastId                                  { get; set; }
        public bool                                     HaveBuiltActiveTouches                  { get; set; }
        public bool                                     HaveActiveTouchesNeedingRefreshNextUpdate { get; set; }

        public static FingerAndTouchState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FingerAndTouchState();

            value.UpdateMask                                = (InputUpdateType)GetInt32(new IntPtr(p + 0x010)); // 0270D77DE5C0 0x10 UpdateMask                  ( 000186705EF0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.Fingers                                   = GetObjectList<Finger>(new IntPtr(p + 0x018), ReversePrism.DataModels.Finger.FromPointer); // 0270D77DE5E0 0x18 Fingers                     ( 000185B7F830 ModelClassListType Finger[] Finger[] List<Finger> Pointer )
            value.ActiveFingers                             = GetObjectList<Finger>(new IntPtr(p + 0x020), ReversePrism.DataModels.Finger.FromPointer); // 0270D77DE600 0x20 ActiveFingers               ( 000185B7F830 ModelClassListType Finger[] Finger[] List<Finger> Pointer )
            value.ActiveTouches                             = GetEnumList<Touch>(new IntPtr(p + 0x028)); // 0270D77DE620 0x28 ActiveTouches               ( 000185CAC3F8 ModelEnumListType Touch[] Touch[] List<Touch> Pointer )
            value.ActiveFingerCount                         = GetInt32(new IntPtr(p + 0x030)); // 0270D77DE640 0x30 ActiveFingerCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActiveTouchCount                          = GetInt32(new IntPtr(p + 0x034)); // 0270D77DE660 0x34 ActiveTouchCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalFingerCount                          = GetInt32(new IntPtr(p + 0x038)); // 0270D77DE680 0x38 TotalFingerCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastId                                    = GetUInt32(new IntPtr(p + 0x03C)); // 0270D77DE6A0 0x3C LastId                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.HaveBuiltActiveTouches                    = GetBool(new IntPtr(p + 0x040)); // 0270D77DE6C0 0x40 HaveBuiltActiveTouches      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HaveActiveTouchesNeedingRefreshNextUpdate = GetBool(new IntPtr(p + 0x041)); // 0270D77DE6E0 0x41 HaveActiveTouchesNeedingRefreshNextUpdate ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
