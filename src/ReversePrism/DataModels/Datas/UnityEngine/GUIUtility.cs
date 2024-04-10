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
    // 010 TakeCapture                              000186679EC0 ModelClassType Action Action Action Pointer
    // 018 ReleaseCapture                           000186679EC0 ModelClassType Action Action Action Pointer
    // 020 processEvent                             Func`3<int, <int>, bool> IL2CPP_TYPE_GENERICINST
    // 028 CleanupRoots                             000186679EC0 ModelClassType Action Action Action Pointer
    // 030 endContainerGUIFromException             Func`2<Exception, bool> IL2CPP_TYPE_GENERICINST
    // 038 GuiChanged                               000186679EC0 ModelClassType Action Action Action Pointer
    // 040 GuiIsExiting                             000186595C30 ModelPrimitiveType bool bool bool Bool
    // 048 s_HasCurrentWindowKeyFocusFunc           Func`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class GUIUtility : DataModel
    {
        public Action?                                  TakeCapture                             { get; set; }
        public Action?                                  ReleaseCapture                          { get; set; }
        public Action?                                  CleanupRoots                            { get; set; }
        public Action?                                  GuiChanged                              { get; set; }
        public bool                                     GuiIsExiting                            { get; set; }

        public static GUIUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIUtility() { Pointer= p0 };

            value.TakeCapture                               = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0245A21E0878 0x10 TakeCapture                 ( 000186679EC0 ModelClassType Action Action Action Pointer )
            value.ReleaseCapture                            = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0245A21E0898 0x18 ReleaseCapture              ( 000186679EC0 ModelClassType Action Action Action Pointer )
            value.CleanupRoots                              = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0245A21E08D8 0x28 CleanupRoots                ( 000186679EC0 ModelClassType Action Action Action Pointer )
            value.GuiChanged                                = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0245A21E0918 0x38 GuiChanged                  ( 000186679EC0 ModelClassType Action Action Action Pointer )
            value.GuiIsExiting                              = GetBool(new IntPtr(p + 0x040)); // 0245A21E0938 0x40 GuiIsExiting                ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
