using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Guid                                     ModelEnumType Guid Guid Guid Int32
    // 020 Type                                     ModelEnumType ModuleType ModuleType ModuleType Int32
    // 028 Disposable                               ModelClassType CriDisposable CriDisposable CriDisposable Pointer
    public partial class ObjectRef : DataModel
    {
        public Guid                                     Guid                                    { get; set; }
        public ModuleType                               Type                                    { get; set; }
        public CriDisposable?                           Disposable                              { get; set; }

        public static ObjectRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectRef() { Pointer= p0 };

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0x10 Guid                        ( ModelEnumType Guid Guid Guid Int32 )
            value.Type                                      = (ModuleType)GetInt32(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelEnumType ModuleType ModuleType ModuleType Int32 )
            value.Disposable                                = GetObject<CriDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriDisposable.FromPointer); // 0x28 Disposable                  ( ModelClassType CriDisposable CriDisposable CriDisposable Pointer )

            return value;
        }
    }
}
