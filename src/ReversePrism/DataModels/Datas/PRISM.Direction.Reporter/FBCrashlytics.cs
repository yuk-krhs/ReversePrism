using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LogActionLimit                           int IL2CPP_TYPE_I4
    // 010 LogActions                               ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer
    // 018 Watcher                                  ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 SuppressReport                           ModelPrimitiveType bool bool bool Bool
    public partial class FBCrashlytics : DataModel
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
            var value   = new FBCrashlytics() { Pointer= p0 };

            value.LogActions                                = GetObjectList<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 LogActions                  ( ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer )
            value.Watcher                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Watcher                     ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SuppressReport                            = GetBool(new IntPtr(p + 0x028)); // 0x28 SuppressReport              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
