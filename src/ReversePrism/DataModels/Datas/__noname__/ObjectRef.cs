using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Guid                                     0001865DC380 ModelEnumType Guid Guid Guid Int32
    // 020 Type                                     000186558D30 ModelEnumType ModuleType ModuleType ModuleType Int32
    // 028 Disposable                               00018664F3E0 ModelClassType CriDisposable CriDisposable CriDisposable Pointer
    public partial class ObjectRef
    {
        public Guid                                     Guid                                    { get; set; }
        public ModuleType                               Type                                    { get; set; }
        public CriDisposable?                           Disposable                              { get; set; }

        public static ObjectRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectRef();

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0270041FB130 0x10 Guid                        ( 0001865DC380 ModelEnumType Guid Guid Guid Int32 )
            value.Type                                      = (ModuleType)GetInt32(new IntPtr(p + 0x020)); // 0270041FB150 0x20 Type                        ( 000186558D30 ModelEnumType ModuleType ModuleType ModuleType Int32 )
            value.Disposable                                = GetObject<CriDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriDisposable.FromPointer); // 0270041FB170 0x28 Disposable                  ( 00018664F3E0 ModelClassType CriDisposable CriDisposable CriDisposable Pointer )

            return value;
        }
    }
}
