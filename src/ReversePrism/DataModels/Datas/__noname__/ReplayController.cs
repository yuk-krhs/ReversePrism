using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Finished                                 ModelPrimitiveType bool bool bool Bool
    // 011 Paused                                   ModelPrimitiveType bool bool bool Bool
    // 014 Position                                 ModelPrimitiveType int int int Int32
    // 018 M_EventTrace                             ModelClassType InputEventTrace InputEventTrace InputEventTrace Pointer
    // 020 M_Enumerator                             ModelClassType Enumerator Enumerator Enumerator Pointer
    // 028 m_DeviceIDMappings                       InlinedArray`1<KeyValuePair`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 040 M_CreateNewDevices                       ModelPrimitiveType bool bool bool Bool
    // 048 m_CreatedDevices                         InlinedArray`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 060 M_OnFinished                             ModelClassType Action Action Action Pointer
    // 068 m_OnEvent                                Action`1<InputEventPtr> IL2CPP_TYPE_GENERICINST
    // 070 M_StartTimeAsPerFirstEvent               ModelPrimitiveType double double double Double
    // 078 M_StartTimeAsPerRuntime                  ModelPrimitiveType double double double Double
    // 080 M_AllEventsByTimeIndex                   ModelPrimitiveType int int int Int32
    // 088 M_AllEventsByTime                        ModelEnumListType List`1<InputEventPtr> List`1<InputEventPtr> List<InputEventPtr> Pointer
    public partial class ReplayController : DataModel
    {
        public bool                                     Finished                                { get; set; }
        public bool                                     Paused                                  { get; set; }
        public int                                      Position                                { get; set; }
        public InputEventTrace?                         M_EventTrace                            { get; set; }
        public Enumerator?                              M_Enumerator                            { get; set; }
        public bool                                     M_CreateNewDevices                      { get; set; }
        public Action?                                  M_OnFinished                            { get; set; }
        public double                                   M_StartTimeAsPerFirstEvent              { get; set; }
        public double                                   M_StartTimeAsPerRuntime                 { get; set; }
        public int                                      M_AllEventsByTimeIndex                  { get; set; }
        public List<InputEventPtr>?                     M_AllEventsByTime                       { get; set; }

        public static ReplayController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReplayController() { Pointer= p0 };

            value.Finished                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Finished                    ( ModelPrimitiveType bool bool bool Bool )
            value.Paused                                    = GetBool(new IntPtr(p + 0x011)); // 0x11 Paused                      ( ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Position                    ( ModelPrimitiveType int int int Int32 )
            value.M_EventTrace                              = GetObject<InputEventTrace>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputEventTrace.FromPointer); // 0x18 M_EventTrace                ( ModelClassType InputEventTrace InputEventTrace InputEventTrace Pointer )
            value.M_Enumerator                              = GetObject<Enumerator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Enumerator.FromPointer); // 0x20 M_Enumerator                ( ModelClassType Enumerator Enumerator Enumerator Pointer )
            value.M_CreateNewDevices                        = GetBool(new IntPtr(p + 0x040)); // 0x40 M_CreateNewDevices          ( ModelPrimitiveType bool bool bool Bool )
            value.M_OnFinished                              = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 0x60 M_OnFinished                ( ModelClassType Action Action Action Pointer )
            value.M_StartTimeAsPerFirstEvent                = GetDouble(new IntPtr(p + 0x070)); // 0x70 M_StartTimeAsPerFirstEvent  ( ModelPrimitiveType double double double Double )
            value.M_StartTimeAsPerRuntime                   = GetDouble(new IntPtr(p + 0x078)); // 0x78 M_StartTimeAsPerRuntime     ( ModelPrimitiveType double double double Double )
            value.M_AllEventsByTimeIndex                    = GetInt32(new IntPtr(p + 0x080)); // 0x80 M_AllEventsByTimeIndex      ( ModelPrimitiveType int int int Int32 )
            value.M_AllEventsByTime                         = GetEnumList<InputEventPtr>(new IntPtr(p + 0x088)); // 0x88 M_AllEventsByTime           ( ModelEnumListType List`1<InputEventPtr> List`1<InputEventPtr> List<InputEventPtr> Pointer )

            return value;
        }
    }
}
