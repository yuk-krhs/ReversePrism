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
    // 020 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 SuppressReport                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FBCrashlytics
    {
        public List<Action>?                            LogActions                              { get; set; }
        public IDisposable?                             Watcher                                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     SuppressReport                          { get; set; }

        public static FBCrashlytics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FBCrashlytics();

            value.LogActions                                = GetObjectList<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 027003C78560 0x10 LogActions                  ( 000185CCB2E8 ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer )
            value.Watcher                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 027003C78580 0x18 Watcher                     ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027003C785A0 0x20 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SuppressReport                            = GetBool(new IntPtr(p + 0x028)); // 027003C785C0 0x28 SuppressReport              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
