using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateMask                               ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 018 Fingers                                  ModelClassListType Finger[] Finger[] List<Finger> Pointer
    // 020 ActiveFingers                            ModelClassListType Finger[] Finger[] List<Finger> Pointer
    // 028 ActiveTouches                            ModelEnumListType Touch[] Touch[] List<Touch> Pointer
    // 030 ActiveFingerCount                        ModelPrimitiveType int int int Int32
    // 034 ActiveTouchCount                         ModelPrimitiveType int int int Int32
    // 038 TotalFingerCount                         ModelPrimitiveType int int int Int32
    // 03C LastId                                   ModelPrimitiveType uint uint uint UInt32
    // 040 HaveBuiltActiveTouches                   ModelPrimitiveType bool bool bool Bool
    // 041 HaveActiveTouchesNeedingRefreshNextUpdate ModelPrimitiveType bool bool bool Bool
    // 048 activeTouchState                         InputStateHistory`1<TouchState> IL2CPP_TYPE_GENERICINST
    public partial class FingerAndTouchState : DataModel
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
            var value   = new FingerAndTouchState() { Pointer= p0 };

            value.UpdateMask                                = (InputUpdateType)GetInt32(new IntPtr(p + 0x010)); // 0x10 UpdateMask                  ( ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.Fingers                                   = GetObjectList<Finger>(new IntPtr(p + 0x018), ReversePrism.DataModels.Finger.FromPointer); // 0x18 Fingers                     ( ModelClassListType Finger[] Finger[] List<Finger> Pointer )
            value.ActiveFingers                             = GetObjectList<Finger>(new IntPtr(p + 0x020), ReversePrism.DataModels.Finger.FromPointer); // 0x20 ActiveFingers               ( ModelClassListType Finger[] Finger[] List<Finger> Pointer )
            value.ActiveTouches                             = GetEnumList<Touch>(new IntPtr(p + 0x028)); // 0x28 ActiveTouches               ( ModelEnumListType Touch[] Touch[] List<Touch> Pointer )
            value.ActiveFingerCount                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 ActiveFingerCount           ( ModelPrimitiveType int int int Int32 )
            value.ActiveTouchCount                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 ActiveTouchCount            ( ModelPrimitiveType int int int Int32 )
            value.TotalFingerCount                          = GetInt32(new IntPtr(p + 0x038)); // 0x38 TotalFingerCount            ( ModelPrimitiveType int int int Int32 )
            value.LastId                                    = GetUInt32(new IntPtr(p + 0x03C)); // 0x3C LastId                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.HaveBuiltActiveTouches                    = GetBool(new IntPtr(p + 0x040)); // 0x40 HaveBuiltActiveTouches      ( ModelPrimitiveType bool bool bool Bool )
            value.HaveActiveTouchesNeedingRefreshNextUpdate = GetBool(new IntPtr(p + 0x041)); // 0x41 HaveActiveTouchesNeedingRefreshNextUpdate ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
