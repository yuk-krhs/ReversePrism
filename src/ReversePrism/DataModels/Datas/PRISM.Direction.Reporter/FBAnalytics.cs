using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LogActionLimit                           int IL2CPP_TYPE_I4
    // 010 LogActions                               000185CCB2E8 ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer
    // 018 Watcher                                  0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FBAnalytics : DataModel
    {
        public List<Action>?                            LogActions                              { get; set; }
        public IDisposable?                             Watcher                                 { get; set; }

        public static FBAnalytics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FBAnalytics() { Pointer= p0 };

            value.LogActions                                = GetObjectList<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0245A3C78178 0x10 LogActions                  ( 000185CCB2E8 ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer )
            value.Watcher                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A3C78198 0x18 Watcher                     ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
