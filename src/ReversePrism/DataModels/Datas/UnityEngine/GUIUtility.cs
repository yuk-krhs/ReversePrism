using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ControlCount                           int IL2CPP_TYPE_I4
    // 004 s_SkinMode                               int IL2CPP_TYPE_I4
    // 008 s_OriginalID                             int IL2CPP_TYPE_I4
    // 010 TakeCapture                              ModelClassType Action Action Action Pointer
    // 018 ReleaseCapture                           ModelClassType Action Action Action Pointer
    // 020 processEvent                             Func`3<int, <int>, bool> IL2CPP_TYPE_GENERICINST
    // 028 CleanupRoots                             ModelClassType Action Action Action Pointer
    // 030 endContainerGUIFromException             Func`2<Exception, bool> IL2CPP_TYPE_GENERICINST
    // 038 GuiChanged                               ModelClassType Action Action Action Pointer
    // 040 beforeEventProcessed                     Action`2<EventType, KeyCode> IL2CPP_TYPE_GENERICINST
    // 048 M_Event                                  ModelClassType Event Event Event Pointer
    // 050 GuiIsExiting                             ModelPrimitiveType bool bool bool Bool
    // 058 s_HasCurrentWindowKeyFocusFunc           Func`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class GUIUtility : DataModel
    {
        public Action?                                  TakeCapture                             { get; set; }
        public Action?                                  ReleaseCapture                          { get; set; }
        public Action?                                  CleanupRoots                            { get; set; }
        public Action?                                  GuiChanged                              { get; set; }
        public Event?                                   M_Event                                 { get; set; }
        public bool                                     GuiIsExiting                            { get; set; }

        public static GUIUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIUtility() { Pointer= p0 };

            value.TakeCapture                               = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 TakeCapture                 ( ModelClassType Action Action Action Pointer )
            value.ReleaseCapture                            = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0x18 ReleaseCapture              ( ModelClassType Action Action Action Pointer )
            value.CleanupRoots                              = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0x28 CleanupRoots                ( ModelClassType Action Action Action Pointer )
            value.GuiChanged                                = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0x38 GuiChanged                  ( ModelClassType Action Action Action Pointer )
            value.M_Event                                   = GetObject<Event>(new IntPtr(p + 0x048), ReversePrism.DataModels.Event.FromPointer); // 0x48 M_Event                     ( ModelClassType Event Event Event Pointer )
            value.GuiIsExiting                              = GetBool(new IntPtr(p + 0x050)); // 0x50 GuiIsExiting                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
